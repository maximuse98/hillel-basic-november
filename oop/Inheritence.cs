using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public class BaseClass
    {
        protected string className = "BaseClass";
        private string baseRequiredField;

        public BaseClass(string baseRequiredField)
        {
            this.baseRequiredField = baseRequiredField;
        }

        public void DoSmth()
        {
            // base class action
        }
    }

    public class DerivedClass2 : BaseClass
    {
        public DerivedClass2(string baseRequiredField) : base(baseRequiredField)
        {
        }
    }

    public class DerivedClass : BaseClass
    {
        public DerivedClass(string baseRequiredField) : base(baseRequiredField)
        {
            className = "DerivedClass";
        }

        public DerivedClass() : base("baseDefaultField")
        {

        }

        public void DoSmthElse()
        { 
            // derived class action
        }
    }

    public class DerivedDerivedClass : DerivedClass
    {
        public DerivedDerivedClass()
        {
            className = "DerivedDerivedClass";
        }

        public void DoSmthElseDerived()
        {
            // derived class action
        }
    }
}
