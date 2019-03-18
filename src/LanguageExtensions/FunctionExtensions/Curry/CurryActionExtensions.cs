using System;
using System.Diagnostics.Contracts;

namespace Jst4Code.FunctionalCS
{
    public static partial class CurryActionExtensions
    {    
        /// <summary>
        /// Transform (value1, value2) => { }
        /// to value1 => value2 => { }
        /// </summary>
        [Pure]
        public static Func<T1, Action<T2>> Curry<T1, T2>(
            this Action<T1, T2> action) =>
                value1 => value2 => action(value1, value2);
        
        /// <summary>
        /// Transform (value1, value2, value3) => { }
        /// to value1 => value2 => value3 => { }
        /// </summary>
        [Pure]
        public static Func<T1, Func<T2, Action<T3>>> Curry<T1, T2, T3>(
            this Action<T1, T2, T3> action) =>
                value1 => value2 => value3 => action(value1, value2, value3);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4) => { }
        /// to value1 => value2 => value3 => value4 => { }
        /// </summary>
        [Pure]
        public static Func<T1, Func<T2, Func<T3, Action<T4>>>> Curry<T1, T2, T3, T4>(
            this Action<T1, T2, T3, T4> action) =>
                value1 => value2 => value3 => value4 => action(value1, value2, value3, value4);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5) => { }
        /// to value1 => value2 => value3 => value4 => value5 => { }
        /// </summary>
        [Pure]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Action<T5>>>>> Curry<T1, T2, T3, T4, T5>(
            this Action<T1, T2, T3, T4, T5> action) =>
                value1 => value2 => value3 => value4 => value5 => action(value1, value2, value3, value4, value5);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6) => { }
        /// to value1 => value2 => value3 => value4 => value5 => value6 => { }
        /// </summary>
        [Pure]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Action<T6>>>>>> Curry<T1, T2, T3, T4, T5, T6>(
            this Action<T1, T2, T3, T4, T5, T6> action) =>
                value1 => value2 => value3 => value4 => value5 => value6 => action(value1, value2, value3, value4, value5, value6);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7) => { }
        /// to value1 => value2 => value3 => value4 => value5 => value6 => value7 => { }
        /// </summary>
        [Pure]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Action<T7>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7>(
            this Action<T1, T2, T3, T4, T5, T6, T7> action) =>
                value1 => value2 => value3 => value4 => value5 => value6 => value7 => action(value1, value2, value3, value4, value5, value6, value7);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8) => { }
        /// to value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => { }
        /// </summary>
        [Pure]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Action<T8>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8> action) =>
                value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => action(value1, value2, value3, value4, value5, value6, value7, value8);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9) => { }
        /// to value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => { }
        /// </summary>
        [Pure]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Action<T9>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action) =>
                value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => action(value1, value2, value3, value4, value5, value6, value7, value8, value9);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9, value10) => { }
        /// to value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => { }
        /// </summary>
        [Pure]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Action<T10>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action) =>
                value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11) => { }
        /// to value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => { }
        /// </summary>
        [Pure]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Action<T11>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action) =>
                value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12) => { }
        /// to value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => { }
        /// </summary>
        [Pure]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Action<T12>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action) =>
                value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13) => { }
        /// to value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => value13 => { }
        /// </summary>
        [Pure]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Action<T13>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action) =>
                value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => value13 => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14) => { }
        /// to value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => value13 => value14 => { }
        /// </summary>
        [Pure]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Action<T14>>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action) =>
                value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => value13 => value14 => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15) => { }
        /// to value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => value13 => value14 => value15 => { }
        /// </summary>
        [Pure]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Action<T15>>>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action) =>
                value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => value13 => value14 => value15 => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16) => { }
        /// to value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => value13 => value14 => value15 => value16 => { }
        /// </summary>
        [Pure]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Action<T16>>>>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action) =>
                value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => value13 => value14 => value15 => value16 => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
    }
}