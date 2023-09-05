using System;

namespace sealed_keyword
{
    public class BaseClass
    {
        public virtual void ExampleVoidMethod() { }

        public virtual int ExampleIntMethod() => 0;

    }

    public class OpenClass : BaseClass
    {
        public override void ExampleVoidMethod() { }

        public override int ExampleIntMethod() => 69;

    }

    public sealed class ClosedClass : BaseClass
    {
        public override void ExampleVoidMethod() { }

        public override int ExampleIntMethod() => 240;

    }
}