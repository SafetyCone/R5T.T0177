using System;

using R5T.T0142;


namespace R5T.T0177
{
    [UtilityTypeMarker]
    public class FunctionBasedConverter<T1, T2> : IConverter<T1, T2>
    {
        public Func<T1, T2> FromT1 { get; set; }
        public Func<T2, T1> FromT2 { get; set; }


        public FunctionBasedConverter()
        {
        }

        public FunctionBasedConverter(
            Func<T1, T2> fromT1,
            Func<T2, T1> fromT2)
        {
            this.FromT1 = fromT1;
            this.FromT2 = fromT2;
        }

        public T1 From(T2 t2)
        {
            var output = this.FromT2(t2);
            return output;
        }

        public T2 From(T1 t1)
        {
            var output = this.FromT1(t1);
            return output;
        }
    }
}
