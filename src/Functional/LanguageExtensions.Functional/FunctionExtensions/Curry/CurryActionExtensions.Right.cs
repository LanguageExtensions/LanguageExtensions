using System;
using System.Diagnostics.Contracts;

namespace LanguageExtensions.Functional
{
    public static partial class CurryActionExtensions
    {    
        /// <summary>
        /// Transform (value1, value2) => { }
        /// to value2 => value1 => { }
        /// </summary>
        [Pure]
        public static Func<T2, Action<T1>> CurryRight<T1, T2>(
            this Action<T1, T2> action) =>
                value2 => value1 => action(value1, value2);
        
        /// <summary>
        /// Transform (value1, value2, value3) => { }
        /// to value3 => value2 => value1 => { }
        /// </summary>
        [Pure]
        public static Func<T3, Func<T2, Action<T1>>> CurryRight<T1, T2, T3>(
            this Action<T1, T2, T3> action) =>
                value3 => value2 => value1 => action(value1, value2, value3);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4) => { }
        /// to value4 => value3 => value2 => value1 => { }
        /// </summary>
        [Pure]
        public static Func<T4, Func<T3, Func<T2, Action<T1>>>> CurryRight<T1, T2, T3, T4>(
            this Action<T1, T2, T3, T4> action) =>
                value4 => value3 => value2 => value1 => action(value1, value2, value3, value4);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5) => { }
        /// to value5 => value4 => value3 => value2 => value1 => { }
        /// </summary>
        [Pure]
        public static Func<T5, Func<T4, Func<T3, Func<T2, Action<T1>>>>> CurryRight<T1, T2, T3, T4, T5>(
            this Action<T1, T2, T3, T4, T5> action) =>
                value5 => value4 => value3 => value2 => value1 => action(value1, value2, value3, value4, value5);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6) => { }
        /// to value6 => value5 => value4 => value3 => value2 => value1 => { }
        /// </summary>
        [Pure]
        public static Func<T6, Func<T5, Func<T4, Func<T3, Func<T2, Action<T1>>>>>> CurryRight<T1, T2, T3, T4, T5, T6>(
            this Action<T1, T2, T3, T4, T5, T6> action) =>
                value6 => value5 => value4 => value3 => value2 => value1 => action(value1, value2, value3, value4, value5, value6);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7) => { }
        /// to value7 => value6 => value5 => value4 => value3 => value2 => value1 => { }
        /// </summary>
        [Pure]
        public static Func<T7, Func<T6, Func<T5, Func<T4, Func<T3, Func<T2, Action<T1>>>>>>> CurryRight<T1, T2, T3, T4, T5, T6, T7>(
            this Action<T1, T2, T3, T4, T5, T6, T7> action) =>
                value7 => value6 => value5 => value4 => value3 => value2 => value1 => action(value1, value2, value3, value4, value5, value6, value7);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8) => { }
        /// to value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => { }
        /// </summary>
        [Pure]
        public static Func<T8, Func<T7, Func<T6, Func<T5, Func<T4, Func<T3, Func<T2, Action<T1>>>>>>>> CurryRight<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8> action) =>
                value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => action(value1, value2, value3, value4, value5, value6, value7, value8);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9) => { }
        /// to value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => { }
        /// </summary>
        [Pure]
        public static Func<T9, Func<T8, Func<T7, Func<T6, Func<T5, Func<T4, Func<T3, Func<T2, Action<T1>>>>>>>>> CurryRight<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action) =>
                value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => action(value1, value2, value3, value4, value5, value6, value7, value8, value9);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9, value10) => { }
        /// to value10 => value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => { }
        /// </summary>
        [Pure]
        public static Func<T10, Func<T9, Func<T8, Func<T7, Func<T6, Func<T5, Func<T4, Func<T3, Func<T2, Action<T1>>>>>>>>>> CurryRight<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action) =>
                value10 => value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11) => { }
        /// to value11 => value10 => value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => { }
        /// </summary>
        [Pure]
        public static Func<T11, Func<T10, Func<T9, Func<T8, Func<T7, Func<T6, Func<T5, Func<T4, Func<T3, Func<T2, Action<T1>>>>>>>>>>> CurryRight<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action) =>
                value11 => value10 => value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12) => { }
        /// to value12 => value11 => value10 => value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => { }
        /// </summary>
        [Pure]
        public static Func<T12, Func<T11, Func<T10, Func<T9, Func<T8, Func<T7, Func<T6, Func<T5, Func<T4, Func<T3, Func<T2, Action<T1>>>>>>>>>>>> CurryRight<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action) =>
                value12 => value11 => value10 => value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13) => { }
        /// to value13 => value12 => value11 => value10 => value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => { }
        /// </summary>
        [Pure]
        public static Func<T13, Func<T12, Func<T11, Func<T10, Func<T9, Func<T8, Func<T7, Func<T6, Func<T5, Func<T4, Func<T3, Func<T2, Action<T1>>>>>>>>>>>>> CurryRight<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action) =>
                value13 => value12 => value11 => value10 => value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14) => { }
        /// to value14 => value13 => value12 => value11 => value10 => value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => { }
        /// </summary>
        [Pure]
        public static Func<T14, Func<T13, Func<T12, Func<T11, Func<T10, Func<T9, Func<T8, Func<T7, Func<T6, Func<T5, Func<T4, Func<T3, Func<T2, Action<T1>>>>>>>>>>>>>> CurryRight<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action) =>
                value14 => value13 => value12 => value11 => value10 => value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15) => { }
        /// to value15 => value14 => value13 => value12 => value11 => value10 => value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => { }
        /// </summary>
        [Pure]
        public static Func<T15, Func<T14, Func<T13, Func<T12, Func<T11, Func<T10, Func<T9, Func<T8, Func<T7, Func<T6, Func<T5, Func<T4, Func<T3, Func<T2, Action<T1>>>>>>>>>>>>>>> CurryRight<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action) =>
                value15 => value14 => value13 => value12 => value11 => value10 => value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16) => { }
        /// to value16 => value15 => value14 => value13 => value12 => value11 => value10 => value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => { }
        /// </summary>
        [Pure]
        public static Func<T16, Func<T15, Func<T14, Func<T13, Func<T12, Func<T11, Func<T10, Func<T9, Func<T8, Func<T7, Func<T6, Func<T5, Func<T4, Func<T3, Func<T2, Action<T1>>>>>>>>>>>>>>>> CurryRight<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action) =>
                value16 => value15 => value14 => value13 => value12 => value11 => value10 => value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
    }
}