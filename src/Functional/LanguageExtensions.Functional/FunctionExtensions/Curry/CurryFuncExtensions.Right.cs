using System;
using System.Diagnostics.Contracts;

namespace Jst4Code.FunctionalCS
{
    public static partial class CurryFuncExtensions
    {    
        /// <summary>
        /// Transform (value1, value2) => result
        /// to value2 => value1 => result
        /// </summary>
        [Pure]
        public static Func<T2, Func<T1, TResult>> CurryRight<T1, T2, TResult>(
            this Func<T1, T2, TResult> function) =>
                value2 => value1 => function(value1, value2);
        
        /// <summary>
        /// Transform (value1, value2, value3) => result
        /// to value3 => value2 => value1 => result
        /// </summary>
        [Pure]
        public static Func<T3, Func<T2, Func<T1, TResult>>> CurryRight<T1, T2, T3, TResult>(
            this Func<T1, T2, T3, TResult> function) =>
                value3 => value2 => value1 => function(value1, value2, value3);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4) => result
        /// to value4 => value3 => value2 => value1 => result
        /// </summary>
        [Pure]
        public static Func<T4, Func<T3, Func<T2, Func<T1, TResult>>>> CurryRight<T1, T2, T3, T4, TResult>(
            this Func<T1, T2, T3, T4, TResult> function) =>
                value4 => value3 => value2 => value1 => function(value1, value2, value3, value4);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5) => result
        /// to value5 => value4 => value3 => value2 => value1 => result
        /// </summary>
        [Pure]
        public static Func<T5, Func<T4, Func<T3, Func<T2, Func<T1, TResult>>>>> CurryRight<T1, T2, T3, T4, T5, TResult>(
            this Func<T1, T2, T3, T4, T5, TResult> function) =>
                value5 => value4 => value3 => value2 => value1 => function(value1, value2, value3, value4, value5);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6) => result
        /// to value6 => value5 => value4 => value3 => value2 => value1 => result
        /// </summary>
        [Pure]
        public static Func<T6, Func<T5, Func<T4, Func<T3, Func<T2, Func<T1, TResult>>>>>> CurryRight<T1, T2, T3, T4, T5, T6, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, TResult> function) =>
                value6 => value5 => value4 => value3 => value2 => value1 => function(value1, value2, value3, value4, value5, value6);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7) => result
        /// to value7 => value6 => value5 => value4 => value3 => value2 => value1 => result
        /// </summary>
        [Pure]
        public static Func<T7, Func<T6, Func<T5, Func<T4, Func<T3, Func<T2, Func<T1, TResult>>>>>>> CurryRight<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> function) =>
                value7 => value6 => value5 => value4 => value3 => value2 => value1 => function(value1, value2, value3, value4, value5, value6, value7);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8) => result
        /// to value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => result
        /// </summary>
        [Pure]
        public static Func<T8, Func<T7, Func<T6, Func<T5, Func<T4, Func<T3, Func<T2, Func<T1, TResult>>>>>>>> CurryRight<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function) =>
                value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => function(value1, value2, value3, value4, value5, value6, value7, value8);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9) => result
        /// to value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => result
        /// </summary>
        [Pure]
        public static Func<T9, Func<T8, Func<T7, Func<T6, Func<T5, Func<T4, Func<T3, Func<T2, Func<T1, TResult>>>>>>>>> CurryRight<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function) =>
                value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => function(value1, value2, value3, value4, value5, value6, value7, value8, value9);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9, value10) => result
        /// to value10 => value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => result
        /// </summary>
        [Pure]
        public static Func<T10, Func<T9, Func<T8, Func<T7, Func<T6, Func<T5, Func<T4, Func<T3, Func<T2, Func<T1, TResult>>>>>>>>>> CurryRight<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function) =>
                value10 => value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11) => result
        /// to value11 => value10 => value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => result
        /// </summary>
        [Pure]
        public static Func<T11, Func<T10, Func<T9, Func<T8, Func<T7, Func<T6, Func<T5, Func<T4, Func<T3, Func<T2, Func<T1, TResult>>>>>>>>>>> CurryRight<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function) =>
                value11 => value10 => value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12) => result
        /// to value12 => value11 => value10 => value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => result
        /// </summary>
        [Pure]
        public static Func<T12, Func<T11, Func<T10, Func<T9, Func<T8, Func<T7, Func<T6, Func<T5, Func<T4, Func<T3, Func<T2, Func<T1, TResult>>>>>>>>>>>> CurryRight<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function) =>
                value12 => value11 => value10 => value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13) => result
        /// to value13 => value12 => value11 => value10 => value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => result
        /// </summary>
        [Pure]
        public static Func<T13, Func<T12, Func<T11, Func<T10, Func<T9, Func<T8, Func<T7, Func<T6, Func<T5, Func<T4, Func<T3, Func<T2, Func<T1, TResult>>>>>>>>>>>>> CurryRight<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function) =>
                value13 => value12 => value11 => value10 => value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14) => result
        /// to value14 => value13 => value12 => value11 => value10 => value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => result
        /// </summary>
        [Pure]
        public static Func<T14, Func<T13, Func<T12, Func<T11, Func<T10, Func<T9, Func<T8, Func<T7, Func<T6, Func<T5, Func<T4, Func<T3, Func<T2, Func<T1, TResult>>>>>>>>>>>>>> CurryRight<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function) =>
                value14 => value13 => value12 => value11 => value10 => value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15) => result
        /// to value15 => value14 => value13 => value12 => value11 => value10 => value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => result
        /// </summary>
        [Pure]
        public static Func<T15, Func<T14, Func<T13, Func<T12, Func<T11, Func<T10, Func<T9, Func<T8, Func<T7, Func<T6, Func<T5, Func<T4, Func<T3, Func<T2, Func<T1, TResult>>>>>>>>>>>>>>> CurryRight<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function) =>
                value15 => value14 => value13 => value12 => value11 => value10 => value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16) => result
        /// to value16 => value15 => value14 => value13 => value12 => value11 => value10 => value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => result
        /// </summary>
        [Pure]
        public static Func<T16, Func<T15, Func<T14, Func<T13, Func<T12, Func<T11, Func<T10, Func<T9, Func<T8, Func<T7, Func<T6, Func<T5, Func<T4, Func<T3, Func<T2, Func<T1, TResult>>>>>>>>>>>>>>>> CurryRight<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function) =>
                value16 => value15 => value14 => value13 => value12 => value11 => value10 => value9 => value8 => value7 => value6 => value5 => value4 => value3 => value2 => value1 => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
    }
}