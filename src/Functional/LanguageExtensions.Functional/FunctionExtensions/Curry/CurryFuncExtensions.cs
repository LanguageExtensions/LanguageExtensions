using System;
using System.Diagnostics.Contracts;

namespace LanguageExtensions.Functional
{
    public static partial class CurryFuncExtensions
    {    
        /// <summary>
        /// Transform (value1, value2) => result
        /// to value1 => value2 => result
        /// </summary>
        [Pure]
        public static Func<T1, Func<T2, TResult>> Curry<T1, T2, TResult>(
            this Func<T1, T2, TResult> function) =>
                value1 => value2 => function(value1, value2);
        
        /// <summary>
        /// Transform (value1, value2, value3) => result
        /// to value1 => value2 => value3 => result
        /// </summary>
        [Pure]
        public static Func<T1, Func<T2, Func<T3, TResult>>> Curry<T1, T2, T3, TResult>(
            this Func<T1, T2, T3, TResult> function) =>
                value1 => value2 => value3 => function(value1, value2, value3);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4) => result
        /// to value1 => value2 => value3 => value4 => result
        /// </summary>
        [Pure]
        public static Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>> Curry<T1, T2, T3, T4, TResult>(
            this Func<T1, T2, T3, T4, TResult> function) =>
                value1 => value2 => value3 => value4 => function(value1, value2, value3, value4);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5) => result
        /// to value1 => value2 => value3 => value4 => value5 => result
        /// </summary>
        [Pure]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TResult>>>>> Curry<T1, T2, T3, T4, T5, TResult>(
            this Func<T1, T2, T3, T4, T5, TResult> function) =>
                value1 => value2 => value3 => value4 => value5 => function(value1, value2, value3, value4, value5);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6) => result
        /// to value1 => value2 => value3 => value4 => value5 => value6 => result
        /// </summary>
        [Pure]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TResult>>>>>> Curry<T1, T2, T3, T4, T5, T6, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, TResult> function) =>
                value1 => value2 => value3 => value4 => value5 => value6 => function(value1, value2, value3, value4, value5, value6);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7) => result
        /// to value1 => value2 => value3 => value4 => value5 => value6 => value7 => result
        /// </summary>
        [Pure]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TResult>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> function) =>
                value1 => value2 => value3 => value4 => value5 => value6 => value7 => function(value1, value2, value3, value4, value5, value6, value7);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8) => result
        /// to value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => result
        /// </summary>
        [Pure]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TResult>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function) =>
                value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => function(value1, value2, value3, value4, value5, value6, value7, value8);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9) => result
        /// to value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => result
        /// </summary>
        [Pure]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TResult>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function) =>
                value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => function(value1, value2, value3, value4, value5, value6, value7, value8, value9);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9, value10) => result
        /// to value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => result
        /// </summary>
        [Pure]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TResult>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function) =>
                value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11) => result
        /// to value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => result
        /// </summary>
        [Pure]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TResult>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function) =>
                value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12) => result
        /// to value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => result
        /// </summary>
        [Pure]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TResult>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function) =>
                value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13) => result
        /// to value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => value13 => result
        /// </summary>
        [Pure]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function) =>
                value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => value13 => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14) => result
        /// to value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => value13 => value14 => result
        /// </summary>
        [Pure]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function) =>
                value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => value13 => value14 => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15) => result
        /// to value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => value13 => value14 => value15 => result
        /// </summary>
        [Pure]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function) =>
                value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => value13 => value14 => value15 => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Transform (value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16) => result
        /// to value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => value13 => value14 => value15 => value16 => result
        /// </summary>
        [Pure]
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, TResult>>>>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function) =>
                value1 => value2 => value3 => value4 => value5 => value6 => value7 => value8 => value9 => value10 => value11 => value12 => value13 => value14 => value15 => value16 => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
    }
}