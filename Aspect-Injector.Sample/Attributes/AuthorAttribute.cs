using System;
using AspectInjector.Broker;

namespace Aspect_Injector.Sample.Attributes
{
    
    [Aspect(Scope.Global)]
    [Injection(typeof(AuthorAttribute))]
    [AttributeUsage(AttributeTargets.Method)]
    public class AuthorAttribute : Attribute
    {
        
        [Advice(Kind.Before, Targets = Target.Method)]
        public void OnBefore([Argument(Source.Name)] string name)
        {
            Console.WriteLine($"Author On Before Entering method {name}");
        }

        [Advice(Kind.After, Targets = Target.Method)]
        public void OnAfter([Argument(Source.Name)] string name)
        {
            Console.WriteLine($"Author On After Entering method {name}");
        }

        [Advice(Kind.Around)]
        public object OnAround([Argument(Source.Name)] string name, [Argument(Source.Arguments)] object[] args, [Argument(Source.Type)] Type hostType, [Argument(Source.Target)] Func<object[],object> target)
        {
            //Don't forget to remove unused parameters as it improves performance!
            //Alt+Enter or Ctrl+. on Method name or Advice attribute to add more Arguments

            Console.WriteLine($"Author On Around Entering {name} from {hostType.Name}");
            var result = target(args);
            Console.WriteLine($"Author On Around Leaving {name} from {hostType.Name}");
            return result;
        }
    }
}