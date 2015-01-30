T4 Text Template Example with Unit Tests [![Build status](https://travis-ci.org/stofte/t4-template-tests.svg?branch=master)](https://travis-ci.org/stofte/t4-template-tests)
----------------------------------------------------------------------------------------------------------------------------------------------------------------

The T4.Generator project contains, along with the code generator itself, 
a console program that reads XML files to write C# code to the 
console. T4.Test contains an example of how the generated code can 
be unit tested. 

The unit tests are generated by a design time T4 text template that 
references the output folder of the T4.Generator project. Since VS 
cannot detect this dependency, the dependency graph must be specified 
otherwise. First start by building the T4.Generator project, then 
manually transform the design time unit test template (right click 
and select run custom tool), after which the VS test runner can be 
used normally. 