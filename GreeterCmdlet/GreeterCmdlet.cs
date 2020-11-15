using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;

namespace Greetings
{
    [Cmdlet(VerbsCommon.Get,"Greeting")]
    public class GetGreetingCommand : PSCmdlet
    {
        // Declare the parameters for the cmdlet.
        [Parameter(
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public string Name { get; set; }
        protected override void ProcessRecord() 
        {
            var greeter = new Greeter(Name);
            var greeting = greeter.SayHello();
            WriteObject(greeting);
        }
    }
    [Cmdlet(VerbsCommon.Get,"Goodbye")]
    public class GetGoodbyeCommand : PSCmdlet
    {
        // Declare the parameters for the cmdlet.
        [Parameter(
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public string Name { get; set; }

        protected override void ProcessRecord() 
        {
            var greeter = new Greeter(Name);
            var goodBye = greeter.SayGoodBye();
            WriteObject(goodBye);
        }
    }
}