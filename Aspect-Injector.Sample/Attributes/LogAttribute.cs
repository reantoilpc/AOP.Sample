using System;
using AspectInjector.Broker;

namespace Aspect_Injector.Sample.Attributes
{
    [Aspect(Scope.Global)]
    [Injection(typeof(LogAttribute))]
    [AttributeUsage(AttributeTargets.Method)]
    public class LogAttribute : Attribute
    {
        [Advice(Kind.Before, Targets = Target.Method)]
        public void OnBefore([Argument(Source.Name)] string name)
        {
            Console.WriteLine($"Log On Before Entering method {name}");
        }

        [Advice(Kind.After, Targets = Target.Method)]
        public void OnAfter([Argument(Source.Name)] string name)
        {
            Console.WriteLine($"Log On After Entering method {name}");
        }
        
        [Advice(Kind.Around, Targets = Target.Method)]
        public object OnAround([Argument(Source.Name)] string name)
        {
            Console.WriteLine($"Log On Around Entering method {name}");
            return null;
        }
    }
}