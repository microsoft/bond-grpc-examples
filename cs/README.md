# Bond Grpc C# Example #

A simple example service, demonstrating the
[Bond-over-gRPC](https://microsoft.github.io/bond/manual/bond_over_grpc.html)
of [Bond](https://github.com/Microsoft/bond).

# Getting started #

You should be able to clone this repository, open the .sln in Visual Studio
2015, and build.

# The examples #

There are two examples in this repository, demonstrating the server- and
client-side of a simple calculator.

* [calculator-service](https://github.com/Microsoft/bond-grpc-examples/tree/master/cs/calculator-service)
* [calculator-client](https://github.com/Microsoft/bond-grpc-examples/tree/master/cs/calculator-client)

Be sure to look at the `.csproj` files as well as the `.cs` files, as Bond
Grpc needs to be integrated into the build as well.

## Running the examples ##

The calculator-client expects that the service is already running and
listening on the expected port, so make sure to run calculator-service
first.

Both examples pause at the end of execution, waiting for you to press the
Enter key.

# Questions? #

For questions about these examples, feel free to open an issue here. For
questions about Bond or Bond Grpc, please use the
[main Bond repository](https://github.com/Microsoft/bond).

# Code of Conduct

This project has adopted the
[Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the
[Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/)
or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any
additional questions or comments.
