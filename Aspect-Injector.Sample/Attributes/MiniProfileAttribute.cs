using System;
using System.Linq;
using AspectInjector.Broker;
using Microsoft.Extensions.Logging;
using StackExchange.Profiling;

namespace Aspect_Injector.Sample.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    [Injection(typeof(MiniProfileAttribute))]
    public class LogCall : Attribute
    {
        public LogCall(string logLevel)
        {
            LogLevel = logLevel;
        }

        public string LogLevel { get; }
    }

    // [Aspect(Scope.Global)]
    // [Injection(typeof(MiniProfileAttribute))]
    // [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    // public class MiniProfileAttribute : Attribute
    // {
    //     [Advice(Kind.Before)]
    //     public void LogEnter([Argument(Source.Name)] string name, [Argument(Source.Triggers)] Attribute[] triggers)
    //     {
    //         var trigger = triggers.OfType<LogCall>().First();
    //
    //         Console.WriteLine($"Calling '{name}' method with loglevel {trigger.LogLevel}");
    //     }
    // }

    [Aspect(Scope.Global)]
    [Injection(typeof(MiniProfileAttribute))]
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class MiniProfileAttribute : Attribute
    {
        private MiniProfiler _miniProfiler;

        [Advice(Kind.Before, Targets = Target.Method)]
        public void OnBefore(
            [Argument(Source.Type)] Type type,
            [Argument(Source.Triggers)] Attribute[] triggers,
            [Argument(Source.Name)] string name)
        {
            var trigger = triggers.OfType<LogCall>().First();
            Console.WriteLine($"[{DateTime.UtcNow}] Method {type.Name}.{name} started");
            _miniProfiler = MiniProfiler.StartNew(trigger.LogLevel);
        }

        [Advice(Kind.Around, Targets = Target.Method)]
        public object OnAround(
            [Argument(Source.Target)] Func<object[], object> methodDelegate,
            [Argument(Source.Arguments)] object[] args)
        {
            using (_miniProfiler.Step(""))
            {
                var result = methodDelegate(args);
                return result;
            }
        }

        [Advice(Kind.After, Targets = Target.Method)]
        public void OnAfter(
            [Argument(Source.Type)] Type type,
            [Argument(Source.Triggers)] Attribute[] triggers,
            [Argument(Source.Name)] string name)
        {
            Console.WriteLine($"[{DateTime.UtcNow}] Method {type.Name}.{name} finished");
            _miniProfiler.Stop();
        }
    }
}