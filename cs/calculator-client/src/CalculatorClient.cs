// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Threading.Tasks;
using Grpc.Core;

namespace Bond.Grpc.Examples.Calculator
{
    class CalculatorClient
    {
        public static void Main()
        {
            var calculatorChannel = new Channel("localhost", 50051, ChannelCredentials.Insecure);
            var calculatorClient = new Calculator.CalculatorClient(calculatorChannel);

            var addArgs = new BinaryOpArgs
            {
                left = 2,
                right = 2
            };

            var addTask = calculatorClient.AddAsync(addArgs).ResponseAsync;
            Display("Add", addArgs, addTask);

            var divArgs = new BinaryOpArgs
            {
                left = 1,
                right = 0
            };

            var divTask = calculatorClient.DivideAsync(divArgs).ResponseAsync;
            Display("Divide", divArgs, divTask);

            Console.ReadLine();
            Task.WaitAll(calculatorChannel.ShutdownAsync());
        }

        private static void Display(string call, BinaryOpArgs args, Task<IMessage<Result>> resultTask)
        {
            var callStr = $"{call}({args.left}, {args.right})";
            try
            {
                var result = resultTask.GetAwaiter().GetResult();
                var answer = result.Payload.Deserialize().value;
                Console.WriteLine($"{callStr} => {answer}");
            }
            catch (RpcException e)
            {
                Console.WriteLine($"Error!: #{e.Status.Detail} with code: {e.Status.StatusCode}");
            }
        }
    }
}
