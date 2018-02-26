# Summer.Net
A .NetStandard 2.0 port test of Spring.Net

For example look that:
- [Summer.Core.Fakes/Common.Logging.cs](https://github.com/luizcarlosfaria/summer-net/blob/netstandard--2-0/Summer.Core/__fakes/Common.Logging.cs)
- [Summer.Core.Fakes/System.Runtime.Remoting.cs](https://github.com/luizcarlosfaria/summer-net/blob/netstandard--2-0/Summer.Core/__fakes/System.Runtime.Remoting.cs)
- These two files address not resolved dependencies.
- The default configuration model, based on ConfigurationManager is not working.

## Factory / DI Example
![spring net-on-dotnetstandard2-docker](http://res.cloudinary.com/luizcarlosfaria/image/upload/v1506499371/SPRING.NET/spring.net-on-dotnetstandard2-docker_xswvba.png)

## Factory / DI / AOP Example
![spring net-on-dotnetstandard2-aop](http://res.cloudinary.com/luizcarlosfaria/image/upload/v1506499371/SPRING.NET/spring.net-on-dotnetstandard2-aop_lif2uw.png)


## See more about on Spring.NET project

https://github.com/spring-projects/spring-net/issues/133


:warning: **It's a proposal, only Spring.Core and Spring.Aop projects was ported to .NET Standard. Other projects does not will be ported on this fork.** :warning: