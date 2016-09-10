# Gaussian Calculator
The Gaussian Calculator is a rudimentary C# implementation of the analytical framework of "functions of random variables" described in the article:

http://www.occhionero.info/opssp.aspx

By simply assigning a set of normal distributions (e.g. setting their averages and standard deviations) in the table and a corresponding list of weight coefficients, it is possible to quickly evaluate the probability density resulting by their linear combination.

This represents the case where the upcoming distribution in a stochastic process is linked to the previous ones by an integro-difference equation. In this case, GC computes future probability densities in groups of 10 but the number of forward steps may be adjusted by the user.

Using this approach, it is not necessary to proceed to the full solution of the integro-differce equation because it can merely be time-evolved one step at a time, in an iterative fashion. However, GC can also be used (with Steps=1) to merely compute the resulting normal distribution of a linear combination of gaussians, based on their respective weight coefficients.

In a normal trading/risk scenario, the ability to evolve the probability density one step into the future may be satisfactory, as it does not require to deal with the complexity of the associated algebraic, equations usually arising in the theory of difference equations and having the degree of the number of coefficients.

The source code is split into two files: a Windows form and a Gaussian class library. This should facilitate those who plan to extract the library, modify it or use it under another application or spreadsheet. For example, it can easily be brought to Excel by the use of the ExcelDNA library and the corresponding attribute. It can also be called by any other managed languages such as VB.Net or F#, depending on the language/paradigm adopted by the programmer.

https://github.com/gocchionero/gaussian-calculator
