# Permutations
This is a simple program written to resolve a problem described on one of the Facebook groups connected to programming.

The problem:

I have N groups, every group contains M subgroups. 

I want to have every combination of groups that one group contains one and only one subgroup.

Example: 
- 1-st group has subgroups: 1,2,3
- 2-nd group has subgroups: 1,2
- 3-rd group has subgroups: 1,2,3,4

The program produces an output like: `001,10,0100` or just `001100100` if no separator was given.

In fact it produces as many lines of the combinations as is the number of multiplication of every subgroups elements number.

'1' means that this subgroup is included, '0' means that this subgroup is NOT included.

In the example above (`001,10,0100`) the combination was chosen:
- From 1-st group: subgroup 3
- From 2-nd group: subgroup 1
- From 3-rd group: subgroup 2

The results can also interpreted in any other way.

# Build and run

This application was build using .Net Core 2.2 on Linux. 

It should by build by typing:

``` dotnet build ```

But it will enough if you just type:

``` dotnet run ``` - the application will be built and run.

This project also should build and run in Visual Studio (I didn't check it, I only build&run it using Bash)
