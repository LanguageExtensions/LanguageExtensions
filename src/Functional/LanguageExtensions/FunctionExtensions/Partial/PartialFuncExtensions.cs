using System;
using System.Diagnostics.Contracts;

namespace Jst4Code.FunctionalCS
{
    public static partial class PartialFuncExtensions
    {
        #region Partial<T1, T2, TResult>
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2) -> TResult (with 1 less parameter)</returns>
        [Pure]
        public static Func<T2, TResult> Partial<T1, T2, TResult>(
            this Func<T1, T2, TResult> function, T1 value1) =>
                (value2) => function(value1, value2);

        #endregion

        #region Partial<T1, T2, T3, TResult>
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <returns>function of type (T3 value3) -> TResult (with 2 less parameter)</returns>
        [Pure]
        public static Func<T3, TResult> Partial<T1, T2, T3, TResult>(
            this Func<T1, T2, T3, TResult> function, T1 value1, T2 value2) =>
                (value3) => function(value1, value2, value3);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2, T3 value3) -> TResult (with 1 less parameter)</returns>
        [Pure]
        public static Func<T2, T3, TResult> Partial<T1, T2, T3, TResult>(
            this Func<T1, T2, T3, TResult> function, T1 value1) =>
                (value2, value3) => function(value1, value2, value3);

        #endregion

        #region Partial<T1, T2, T3, T4, TResult>
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <returns>function of type (T4 value4) -> TResult (with 3 less parameter)</returns>
        [Pure]
        public static Func<T4, TResult> Partial<T1, T2, T3, T4, TResult>(
            this Func<T1, T2, T3, T4, TResult> function, T1 value1, T2 value2, T3 value3) =>
                (value4) => function(value1, value2, value3, value4);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <returns>function of type (T3 value3, T4 value4) -> TResult (with 2 less parameter)</returns>
        [Pure]
        public static Func<T3, T4, TResult> Partial<T1, T2, T3, T4, TResult>(
            this Func<T1, T2, T3, T4, TResult> function, T1 value1, T2 value2) =>
                (value3, value4) => function(value1, value2, value3, value4);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2, T3 value3, T4 value4) -> TResult (with 1 less parameter)</returns>
        [Pure]
        public static Func<T2, T3, T4, TResult> Partial<T1, T2, T3, T4, TResult>(
            this Func<T1, T2, T3, T4, TResult> function, T1 value1) =>
                (value2, value3, value4) => function(value1, value2, value3, value4);

        #endregion

        #region Partial<T1, T2, T3, T4, T5, TResult>
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <returns>function of type (T5 value5) -> TResult (with 4 less parameter)</returns>
        [Pure]
        public static Func<T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(
            this Func<T1, T2, T3, T4, T5, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5) => function(value1, value2, value3, value4, value5);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <returns>function of type (T4 value4, T5 value5) -> TResult (with 3 less parameter)</returns>
        [Pure]
        public static Func<T4, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(
            this Func<T1, T2, T3, T4, T5, TResult> function, T1 value1, T2 value2, T3 value3) =>
                (value4, value5) => function(value1, value2, value3, value4, value5);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <returns>function of type (T3 value3, T4 value4, T5 value5) -> TResult (with 2 less parameter)</returns>
        [Pure]
        public static Func<T3, T4, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(
            this Func<T1, T2, T3, T4, T5, TResult> function, T1 value1, T2 value2) =>
                (value3, value4, value5) => function(value1, value2, value3, value4, value5);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2, T3 value3, T4 value4, T5 value5) -> TResult (with 1 less parameter)</returns>
        [Pure]
        public static Func<T2, T3, T4, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(
            this Func<T1, T2, T3, T4, T5, TResult> function, T1 value1) =>
                (value2, value3, value4, value5) => function(value1, value2, value3, value4, value5);

        #endregion

        #region Partial<T1, T2, T3, T4, T5, T6, TResult>
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <returns>function of type (T6 value6) -> TResult (with 5 less parameter)</returns>
        [Pure]
        public static Func<T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6) => function(value1, value2, value3, value4, value5, value6);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <returns>function of type (T5 value5, T6 value6) -> TResult (with 4 less parameter)</returns>
        [Pure]
        public static Func<T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6) => function(value1, value2, value3, value4, value5, value6);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <returns>function of type (T4 value4, T5 value5, T6 value6) -> TResult (with 3 less parameter)</returns>
        [Pure]
        public static Func<T4, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6) => function(value1, value2, value3, value4, value5, value6);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <returns>function of type (T3 value3, T4 value4, T5 value5, T6 value6) -> TResult (with 2 less parameter)</returns>
        [Pure]
        public static Func<T3, T4, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 value1, T2 value2) =>
                (value3, value4, value5, value6) => function(value1, value2, value3, value4, value5, value6);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) -> TResult (with 1 less parameter)</returns>
        [Pure]
        public static Func<T2, T3, T4, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 value1) =>
                (value2, value3, value4, value5, value6) => function(value1, value2, value3, value4, value5, value6);

        #endregion

        #region Partial<T1, T2, T3, T4, T5, T6, T7, TResult>
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <returns>function of type (T7 value7) -> TResult (with 6 less parameter)</returns>
        [Pure]
        public static Func<T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7) => function(value1, value2, value3, value4, value5, value6, value7);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <returns>function of type (T6 value6, T7 value7) -> TResult (with 5 less parameter)</returns>
        [Pure]
        public static Func<T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7) => function(value1, value2, value3, value4, value5, value6, value7);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <returns>function of type (T5 value5, T6 value6, T7 value7) -> TResult (with 4 less parameter)</returns>
        [Pure]
        public static Func<T5, T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7) => function(value1, value2, value3, value4, value5, value6, value7);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <returns>function of type (T4 value4, T5 value5, T6 value6, T7 value7) -> TResult (with 3 less parameter)</returns>
        [Pure]
        public static Func<T4, T5, T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7) => function(value1, value2, value3, value4, value5, value6, value7);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <returns>function of type (T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) -> TResult (with 2 less parameter)</returns>
        [Pure]
        public static Func<T3, T4, T5, T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7) => function(value1, value2, value3, value4, value5, value6, value7);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) -> TResult (with 1 less parameter)</returns>
        [Pure]
        public static Func<T2, T3, T4, T5, T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 value1) =>
                (value2, value3, value4, value5, value6, value7) => function(value1, value2, value3, value4, value5, value6, value7);

        #endregion

        #region Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <returns>function of type (T8 value8) -> TResult (with 7 less parameter)</returns>
        [Pure]
        public static Func<T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) =>
                (value8) => function(value1, value2, value3, value4, value5, value6, value7, value8);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <returns>function of type (T7 value7, T8 value8) -> TResult (with 6 less parameter)</returns>
        [Pure]
        public static Func<T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7, value8) => function(value1, value2, value3, value4, value5, value6, value7, value8);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <returns>function of type (T6 value6, T7 value7, T8 value8) -> TResult (with 5 less parameter)</returns>
        [Pure]
        public static Func<T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7, value8) => function(value1, value2, value3, value4, value5, value6, value7, value8);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <returns>function of type (T5 value5, T6 value6, T7 value7, T8 value8) -> TResult (with 4 less parameter)</returns>
        [Pure]
        public static Func<T5, T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7, value8) => function(value1, value2, value3, value4, value5, value6, value7, value8);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <returns>function of type (T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) -> TResult (with 3 less parameter)</returns>
        [Pure]
        public static Func<T4, T5, T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7, value8) => function(value1, value2, value3, value4, value5, value6, value7, value8);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <returns>function of type (T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) -> TResult (with 2 less parameter)</returns>
        [Pure]
        public static Func<T3, T4, T5, T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7, value8) => function(value1, value2, value3, value4, value5, value6, value7, value8);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) -> TResult (with 1 less parameter)</returns>
        [Pure]
        public static Func<T2, T3, T4, T5, T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 value1) =>
                (value2, value3, value4, value5, value6, value7, value8) => function(value1, value2, value3, value4, value5, value6, value7, value8);

        #endregion

        #region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <returns>function of type (T9 value9) -> TResult (with 8 less parameter)</returns>
        [Pure]
        public static Func<T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) =>
                (value9) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <returns>function of type (T8 value8, T9 value9) -> TResult (with 7 less parameter)</returns>
        [Pure]
        public static Func<T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) =>
                (value8, value9) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <returns>function of type (T7 value7, T8 value8, T9 value9) -> TResult (with 6 less parameter)</returns>
        [Pure]
        public static Func<T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7, value8, value9) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <returns>function of type (T6 value6, T7 value7, T8 value8, T9 value9) -> TResult (with 5 less parameter)</returns>
        [Pure]
        public static Func<T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7, value8, value9) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <returns>function of type (T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) -> TResult (with 4 less parameter)</returns>
        [Pure]
        public static Func<T5, T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7, value8, value9) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <returns>function of type (T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) -> TResult (with 3 less parameter)</returns>
        [Pure]
        public static Func<T4, T5, T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7, value8, value9) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <returns>function of type (T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) -> TResult (with 2 less parameter)</returns>
        [Pure]
        public static Func<T3, T4, T5, T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7, value8, value9) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) -> TResult (with 1 less parameter)</returns>
        [Pure]
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 value1) =>
                (value2, value3, value4, value5, value6, value7, value8, value9) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9);

        #endregion

        #region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <returns>function of type (T10 value10) -> TResult (with 9 less parameter)</returns>
        [Pure]
        public static Func<T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) =>
                (value10) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <returns>function of type (T9 value9, T10 value10) -> TResult (with 8 less parameter)</returns>
        [Pure]
        public static Func<T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) =>
                (value9, value10) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <returns>function of type (T8 value8, T9 value9, T10 value10) -> TResult (with 7 less parameter)</returns>
        [Pure]
        public static Func<T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) =>
                (value8, value9, value10) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <returns>function of type (T7 value7, T8 value8, T9 value9, T10 value10) -> TResult (with 6 less parameter)</returns>
        [Pure]
        public static Func<T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7, value8, value9, value10) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <returns>function of type (T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) -> TResult (with 5 less parameter)</returns>
        [Pure]
        public static Func<T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7, value8, value9, value10) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <returns>function of type (T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) -> TResult (with 4 less parameter)</returns>
        [Pure]
        public static Func<T5, T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7, value8, value9, value10) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <returns>function of type (T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) -> TResult (with 3 less parameter)</returns>
        [Pure]
        public static Func<T4, T5, T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7, value8, value9, value10) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <returns>function of type (T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) -> TResult (with 2 less parameter)</returns>
        [Pure]
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7, value8, value9, value10) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) -> TResult (with 1 less parameter)</returns>
        [Pure]
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 value1) =>
                (value2, value3, value4, value5, value6, value7, value8, value9, value10) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);

        #endregion

        #region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <param name="value10">parameter 10 of type T10</param>
        /// <returns>function of type (T11 value11) -> TResult (with 10 less parameter)</returns>
        [Pure]
        public static Func<T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) =>
                (value11) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <returns>function of type (T10 value10, T11 value11) -> TResult (with 9 less parameter)</returns>
        [Pure]
        public static Func<T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) =>
                (value10, value11) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <returns>function of type (T9 value9, T10 value10, T11 value11) -> TResult (with 8 less parameter)</returns>
        [Pure]
        public static Func<T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) =>
                (value9, value10, value11) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <returns>function of type (T8 value8, T9 value9, T10 value10, T11 value11) -> TResult (with 7 less parameter)</returns>
        [Pure]
        public static Func<T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) =>
                (value8, value9, value10, value11) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <returns>function of type (T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) -> TResult (with 6 less parameter)</returns>
        [Pure]
        public static Func<T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7, value8, value9, value10, value11) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <returns>function of type (T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) -> TResult (with 5 less parameter)</returns>
        [Pure]
        public static Func<T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7, value8, value9, value10, value11) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <returns>function of type (T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) -> TResult (with 4 less parameter)</returns>
        [Pure]
        public static Func<T5, T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7, value8, value9, value10, value11) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <returns>function of type (T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) -> TResult (with 3 less parameter)</returns>
        [Pure]
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7, value8, value9, value10, value11) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <returns>function of type (T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) -> TResult (with 2 less parameter)</returns>
        [Pure]
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7, value8, value9, value10, value11) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) -> TResult (with 1 less parameter)</returns>
        [Pure]
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 value1) =>
                (value2, value3, value4, value5, value6, value7, value8, value9, value10, value11) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

        #endregion

        #region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <param name="value10">parameter 10 of type T10</param>
        /// <param name="value11">parameter 11 of type T11</param>
        /// <returns>function of type (T12 value12) -> TResult (with 11 less parameter)</returns>
        [Pure]
        public static Func<T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) =>
                (value12) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <param name="value10">parameter 10 of type T10</param>
        /// <returns>function of type (T11 value11, T12 value12) -> TResult (with 10 less parameter)</returns>
        [Pure]
        public static Func<T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) =>
                (value11, value12) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <returns>function of type (T10 value10, T11 value11, T12 value12) -> TResult (with 9 less parameter)</returns>
        [Pure]
        public static Func<T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) =>
                (value10, value11, value12) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <returns>function of type (T9 value9, T10 value10, T11 value11, T12 value12) -> TResult (with 8 less parameter)</returns>
        [Pure]
        public static Func<T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) =>
                (value9, value10, value11, value12) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <returns>function of type (T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) -> TResult (with 7 less parameter)</returns>
        [Pure]
        public static Func<T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) =>
                (value8, value9, value10, value11, value12) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <returns>function of type (T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) -> TResult (with 6 less parameter)</returns>
        [Pure]
        public static Func<T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7, value8, value9, value10, value11, value12) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <returns>function of type (T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) -> TResult (with 5 less parameter)</returns>
        [Pure]
        public static Func<T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7, value8, value9, value10, value11, value12) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <returns>function of type (T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) -> TResult (with 4 less parameter)</returns>
        [Pure]
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7, value8, value9, value10, value11, value12) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <returns>function of type (T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) -> TResult (with 3 less parameter)</returns>
        [Pure]
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7, value8, value9, value10, value11, value12) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <returns>function of type (T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) -> TResult (with 2 less parameter)</returns>
        [Pure]
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7, value8, value9, value10, value11, value12) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) -> TResult (with 1 less parameter)</returns>
        [Pure]
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 value1) =>
                (value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

        #endregion

        #region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <param name="value10">parameter 10 of type T10</param>
        /// <param name="value11">parameter 11 of type T11</param>
        /// <param name="value12">parameter 12 of type T12</param>
        /// <returns>function of type (T13 value13) -> TResult (with 12 less parameter)</returns>
        [Pure]
        public static Func<T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) =>
                (value13) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <param name="value10">parameter 10 of type T10</param>
        /// <param name="value11">parameter 11 of type T11</param>
        /// <returns>function of type (T12 value12, T13 value13) -> TResult (with 11 less parameter)</returns>
        [Pure]
        public static Func<T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) =>
                (value12, value13) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <param name="value10">parameter 10 of type T10</param>
        /// <returns>function of type (T11 value11, T12 value12, T13 value13) -> TResult (with 10 less parameter)</returns>
        [Pure]
        public static Func<T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) =>
                (value11, value12, value13) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <returns>function of type (T10 value10, T11 value11, T12 value12, T13 value13) -> TResult (with 9 less parameter)</returns>
        [Pure]
        public static Func<T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) =>
                (value10, value11, value12, value13) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <returns>function of type (T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) -> TResult (with 8 less parameter)</returns>
        [Pure]
        public static Func<T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) =>
                (value9, value10, value11, value12, value13) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <returns>function of type (T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) -> TResult (with 7 less parameter)</returns>
        [Pure]
        public static Func<T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) =>
                (value8, value9, value10, value11, value12, value13) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <returns>function of type (T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) -> TResult (with 6 less parameter)</returns>
        [Pure]
        public static Func<T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7, value8, value9, value10, value11, value12, value13) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <returns>function of type (T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) -> TResult (with 5 less parameter)</returns>
        [Pure]
        public static Func<T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7, value8, value9, value10, value11, value12, value13) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <returns>function of type (T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) -> TResult (with 4 less parameter)</returns>
        [Pure]
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7, value8, value9, value10, value11, value12, value13) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <returns>function of type (T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) -> TResult (with 3 less parameter)</returns>
        [Pure]
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7, value8, value9, value10, value11, value12, value13) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <returns>function of type (T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) -> TResult (with 2 less parameter)</returns>
        [Pure]
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) -> TResult (with 1 less parameter)</returns>
        [Pure]
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 value1) =>
                (value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

        #endregion

        #region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <param name="value10">parameter 10 of type T10</param>
        /// <param name="value11">parameter 11 of type T11</param>
        /// <param name="value12">parameter 12 of type T12</param>
        /// <param name="value13">parameter 13 of type T13</param>
        /// <returns>function of type (T14 value14) -> TResult (with 13 less parameter)</returns>
        [Pure]
        public static Func<T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) =>
                (value14) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <param name="value10">parameter 10 of type T10</param>
        /// <param name="value11">parameter 11 of type T11</param>
        /// <param name="value12">parameter 12 of type T12</param>
        /// <returns>function of type (T13 value13, T14 value14) -> TResult (with 12 less parameter)</returns>
        [Pure]
        public static Func<T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) =>
                (value13, value14) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <param name="value10">parameter 10 of type T10</param>
        /// <param name="value11">parameter 11 of type T11</param>
        /// <returns>function of type (T12 value12, T13 value13, T14 value14) -> TResult (with 11 less parameter)</returns>
        [Pure]
        public static Func<T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) =>
                (value12, value13, value14) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <param name="value10">parameter 10 of type T10</param>
        /// <returns>function of type (T11 value11, T12 value12, T13 value13, T14 value14) -> TResult (with 10 less parameter)</returns>
        [Pure]
        public static Func<T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) =>
                (value11, value12, value13, value14) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <returns>function of type (T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) -> TResult (with 9 less parameter)</returns>
        [Pure]
        public static Func<T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) =>
                (value10, value11, value12, value13, value14) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <returns>function of type (T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) -> TResult (with 8 less parameter)</returns>
        [Pure]
        public static Func<T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) =>
                (value9, value10, value11, value12, value13, value14) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <returns>function of type (T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) -> TResult (with 7 less parameter)</returns>
        [Pure]
        public static Func<T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) =>
                (value8, value9, value10, value11, value12, value13, value14) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <returns>function of type (T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) -> TResult (with 6 less parameter)</returns>
        [Pure]
        public static Func<T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7, value8, value9, value10, value11, value12, value13, value14) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <returns>function of type (T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) -> TResult (with 5 less parameter)</returns>
        [Pure]
        public static Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7, value8, value9, value10, value11, value12, value13, value14) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <returns>function of type (T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) -> TResult (with 4 less parameter)</returns>
        [Pure]
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7, value8, value9, value10, value11, value12, value13, value14) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <returns>function of type (T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) -> TResult (with 3 less parameter)</returns>
        [Pure]
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <returns>function of type (T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) -> TResult (with 2 less parameter)</returns>
        [Pure]
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) -> TResult (with 1 less parameter)</returns>
        [Pure]
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 value1) =>
                (value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

        #endregion

        #region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <param name="value10">parameter 10 of type T10</param>
        /// <param name="value11">parameter 11 of type T11</param>
        /// <param name="value12">parameter 12 of type T12</param>
        /// <param name="value13">parameter 13 of type T13</param>
        /// <param name="value14">parameter 14 of type T14</param>
        /// <returns>function of type (T15 value15) -> TResult (with 14 less parameter)</returns>
        [Pure]
        public static Func<T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) =>
                (value15) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <param name="value10">parameter 10 of type T10</param>
        /// <param name="value11">parameter 11 of type T11</param>
        /// <param name="value12">parameter 12 of type T12</param>
        /// <param name="value13">parameter 13 of type T13</param>
        /// <returns>function of type (T14 value14, T15 value15) -> TResult (with 13 less parameter)</returns>
        [Pure]
        public static Func<T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) =>
                (value14, value15) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <param name="value10">parameter 10 of type T10</param>
        /// <param name="value11">parameter 11 of type T11</param>
        /// <param name="value12">parameter 12 of type T12</param>
        /// <returns>function of type (T13 value13, T14 value14, T15 value15) -> TResult (with 12 less parameter)</returns>
        [Pure]
        public static Func<T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) =>
                (value13, value14, value15) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <param name="value10">parameter 10 of type T10</param>
        /// <param name="value11">parameter 11 of type T11</param>
        /// <returns>function of type (T12 value12, T13 value13, T14 value14, T15 value15) -> TResult (with 11 less parameter)</returns>
        [Pure]
        public static Func<T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) =>
                (value12, value13, value14, value15) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <param name="value10">parameter 10 of type T10</param>
        /// <returns>function of type (T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) -> TResult (with 10 less parameter)</returns>
        [Pure]
        public static Func<T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) =>
                (value11, value12, value13, value14, value15) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <returns>function of type (T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) -> TResult (with 9 less parameter)</returns>
        [Pure]
        public static Func<T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) =>
                (value10, value11, value12, value13, value14, value15) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <returns>function of type (T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) -> TResult (with 8 less parameter)</returns>
        [Pure]
        public static Func<T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) =>
                (value9, value10, value11, value12, value13, value14, value15) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <returns>function of type (T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) -> TResult (with 7 less parameter)</returns>
        [Pure]
        public static Func<T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) =>
                (value8, value9, value10, value11, value12, value13, value14, value15) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <returns>function of type (T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) -> TResult (with 6 less parameter)</returns>
        [Pure]
        public static Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7, value8, value9, value10, value11, value12, value13, value14, value15) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <returns>function of type (T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) -> TResult (with 5 less parameter)</returns>
        [Pure]
        public static Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7, value8, value9, value10, value11, value12, value13, value14, value15) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <returns>function of type (T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) -> TResult (with 4 less parameter)</returns>
        [Pure]
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <returns>function of type (T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) -> TResult (with 3 less parameter)</returns>
        [Pure]
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <returns>function of type (T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) -> TResult (with 2 less parameter)</returns>
        [Pure]
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) -> TResult (with 1 less parameter)</returns>
        [Pure]
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 value1) =>
                (value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

        #endregion

        #region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <param name="value10">parameter 10 of type T10</param>
        /// <param name="value11">parameter 11 of type T11</param>
        /// <param name="value12">parameter 12 of type T12</param>
        /// <param name="value13">parameter 13 of type T13</param>
        /// <param name="value14">parameter 14 of type T14</param>
        /// <param name="value15">parameter 15 of type T15</param>
        /// <returns>function of type (T16 value16) -> TResult (with 15 less parameter)</returns>
        [Pure]
        public static Func<T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) =>
                (value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <param name="value10">parameter 10 of type T10</param>
        /// <param name="value11">parameter 11 of type T11</param>
        /// <param name="value12">parameter 12 of type T12</param>
        /// <param name="value13">parameter 13 of type T13</param>
        /// <param name="value14">parameter 14 of type T14</param>
        /// <returns>function of type (T15 value15, T16 value16) -> TResult (with 14 less parameter)</returns>
        [Pure]
        public static Func<T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) =>
                (value15, value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <param name="value10">parameter 10 of type T10</param>
        /// <param name="value11">parameter 11 of type T11</param>
        /// <param name="value12">parameter 12 of type T12</param>
        /// <param name="value13">parameter 13 of type T13</param>
        /// <returns>function of type (T14 value14, T15 value15, T16 value16) -> TResult (with 13 less parameter)</returns>
        [Pure]
        public static Func<T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) =>
                (value14, value15, value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <param name="value10">parameter 10 of type T10</param>
        /// <param name="value11">parameter 11 of type T11</param>
        /// <param name="value12">parameter 12 of type T12</param>
        /// <returns>function of type (T13 value13, T14 value14, T15 value15, T16 value16) -> TResult (with 12 less parameter)</returns>
        [Pure]
        public static Func<T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) =>
                (value13, value14, value15, value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <param name="value10">parameter 10 of type T10</param>
        /// <param name="value11">parameter 11 of type T11</param>
        /// <returns>function of type (T12 value12, T13 value13, T14 value14, T15 value15, T16 value16) -> TResult (with 11 less parameter)</returns>
        [Pure]
        public static Func<T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) =>
                (value12, value13, value14, value15, value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <param name="value10">parameter 10 of type T10</param>
        /// <returns>function of type (T11 value11, T12 value12, T13 value13, T14 value14, T15 value15, T16 value16) -> TResult (with 10 less parameter)</returns>
        [Pure]
        public static Func<T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) =>
                (value11, value12, value13, value14, value15, value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <returns>function of type (T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15, T16 value16) -> TResult (with 9 less parameter)</returns>
        [Pure]
        public static Func<T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) =>
                (value10, value11, value12, value13, value14, value15, value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <returns>function of type (T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15, T16 value16) -> TResult (with 8 less parameter)</returns>
        [Pure]
        public static Func<T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) =>
                (value9, value10, value11, value12, value13, value14, value15, value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <returns>function of type (T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15, T16 value16) -> TResult (with 7 less parameter)</returns>
        [Pure]
        public static Func<T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) =>
                (value8, value9, value10, value11, value12, value13, value14, value15, value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <returns>function of type (T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15, T16 value16) -> TResult (with 6 less parameter)</returns>
        [Pure]
        public static Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7, value8, value9, value10, value11, value12, value13, value14, value15, value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <returns>function of type (T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15, T16 value16) -> TResult (with 5 less parameter)</returns>
        [Pure]
        public static Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <returns>function of type (T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15, T16 value16) -> TResult (with 4 less parameter)</returns>
        [Pure]
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <returns>function of type (T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15, T16 value16) -> TResult (with 3 less parameter)</returns>
        [Pure]
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <returns>function of type (T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15, T16 value16) -> TResult (with 2 less parameter)</returns>
        [Pure]
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        
        /// <summary>
        /// Partial Execution of target function
        /// </summary>
        /// <param name="action">function from target Func of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> TResult</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15, T16 value16) -> TResult (with 1 less parameter)</returns>
        [Pure]
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1) =>
                (value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

        #endregion
    }
}