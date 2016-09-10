# Gaussian Calculator
The Gaussian Calculator is a rudimentary C# implementation of the analytical framework of "functions of random variables" described in this article:

http://www.occhionero.info/opssp.aspx

By simply assigning a set of normal distributions (e.g. setting their averages and standard deviations) in the table and a corresponding list of weight coefficients, it is possible to quickly evaluate the probability density resulting by their linear combination.

This represents the case where the upcoming distribution in a stochastic process is linked to the previous ones by an integro-difference equation. In this case, GC computes future probability densities in groups of 10 but the number of forward steps may be adjusted by the user.

Using this approach, it is not necessary to proceed to the full solution of the integro-differce equation because it can merely be time-evolved one step at a time, in an iterative fashion. However, GC can also be used (with Steps=1) to merely compute the resulting normal distribution of a linear combination of gaussians, based on their respective weight coefficients.

In a normal trading/risk scenario, the ability to evolve the probability density one step into the future may be satisfactory, as it does not require to deal with the complexity of the associated algebraic equations, usually arising in the theory of difference equations and having degree equal to the number of weight coefficients.

The source code is available on GitHub at the following address:

https://github.com/gocchionero/gaussian-calculator

and is split into two files of a Windows form application: a program and a Gaussian class library. The Gaussian class implements the basic arithmetic operators so as to abstract the use of the Dirac's Delta function (the one appearing in the multi-linear integral operator) into managed code; without requiring to rely upon a symbolic computation environment such as Matlab or Mathematica; also emphasizing how sometimes it is possible to revert complex computational problems into stand-alone code.

This should also facilitate those who plan to extract the class library, modify it or use it under another application or spreadsheet. For example, it can easily be brought to Excel by the use of the ExcelDNA library appending the corresponding attribute. It can also be called by any other managed languages such as VB.Net, F# or even PowerShell, depending on the language/paradigm adopted by the programmer.
