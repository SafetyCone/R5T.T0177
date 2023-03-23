using System;

using R5T.T0142;


namespace R5T.T0177
{
    [UtilityTypeMarker]
    public interface IConverter<T1, T2>
    {
        public T1 From(T2 t2);
        public T2 From(T1 t1);
    }
}
