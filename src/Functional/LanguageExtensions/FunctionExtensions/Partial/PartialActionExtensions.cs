using System;
using System.Diagnostics.Contracts;

namespace Jst4Code.FunctionalCS
{
    public static partial class PartialActionExtensions
    {
        #region Partial<T1, T2, void>
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2) -> void (with 1 less parameter)</returns>
        [Pure]
        public static Action<T2> Partial<T1, T2>(
            this Action<T1, T2> action, T1 value1) =>
                (value2) => action(value1, value2);

        #endregion

        #region Partial<T1, T2, T3, void>
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <returns>function of type (T3 value3) -> void (with 2 less parameter)</returns>
        [Pure]
        public static Action<T3> Partial<T1, T2, T3>(
            this Action<T1, T2, T3> action, T1 value1, T2 value2) =>
                (value3) => action(value1, value2, value3);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2, T3 value3) -> void (with 1 less parameter)</returns>
        [Pure]
        public static Action<T2, T3> Partial<T1, T2, T3>(
            this Action<T1, T2, T3> action, T1 value1) =>
                (value2, value3) => action(value1, value2, value3);

        #endregion

        #region Partial<T1, T2, T3, T4, void>
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <returns>function of type (T4 value4) -> void (with 3 less parameter)</returns>
        [Pure]
        public static Action<T4> Partial<T1, T2, T3, T4>(
            this Action<T1, T2, T3, T4> action, T1 value1, T2 value2, T3 value3) =>
                (value4) => action(value1, value2, value3, value4);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <returns>function of type (T3 value3, T4 value4) -> void (with 2 less parameter)</returns>
        [Pure]
        public static Action<T3, T4> Partial<T1, T2, T3, T4>(
            this Action<T1, T2, T3, T4> action, T1 value1, T2 value2) =>
                (value3, value4) => action(value1, value2, value3, value4);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2, T3 value3, T4 value4) -> void (with 1 less parameter)</returns>
        [Pure]
        public static Action<T2, T3, T4> Partial<T1, T2, T3, T4>(
            this Action<T1, T2, T3, T4> action, T1 value1) =>
                (value2, value3, value4) => action(value1, value2, value3, value4);

        #endregion

        #region Partial<T1, T2, T3, T4, T5, void>
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <returns>function of type (T5 value5) -> void (with 4 less parameter)</returns>
        [Pure]
        public static Action<T5> Partial<T1, T2, T3, T4, T5>(
            this Action<T1, T2, T3, T4, T5> action, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5) => action(value1, value2, value3, value4, value5);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <returns>function of type (T4 value4, T5 value5) -> void (with 3 less parameter)</returns>
        [Pure]
        public static Action<T4, T5> Partial<T1, T2, T3, T4, T5>(
            this Action<T1, T2, T3, T4, T5> action, T1 value1, T2 value2, T3 value3) =>
                (value4, value5) => action(value1, value2, value3, value4, value5);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <returns>function of type (T3 value3, T4 value4, T5 value5) -> void (with 2 less parameter)</returns>
        [Pure]
        public static Action<T3, T4, T5> Partial<T1, T2, T3, T4, T5>(
            this Action<T1, T2, T3, T4, T5> action, T1 value1, T2 value2) =>
                (value3, value4, value5) => action(value1, value2, value3, value4, value5);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2, T3 value3, T4 value4, T5 value5) -> void (with 1 less parameter)</returns>
        [Pure]
        public static Action<T2, T3, T4, T5> Partial<T1, T2, T3, T4, T5>(
            this Action<T1, T2, T3, T4, T5> action, T1 value1) =>
                (value2, value3, value4, value5) => action(value1, value2, value3, value4, value5);

        #endregion

        #region Partial<T1, T2, T3, T4, T5, T6, void>
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <returns>function of type (T6 value6) -> void (with 5 less parameter)</returns>
        [Pure]
        public static Action<T6> Partial<T1, T2, T3, T4, T5, T6>(
            this Action<T1, T2, T3, T4, T5, T6> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6) => action(value1, value2, value3, value4, value5, value6);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <returns>function of type (T5 value5, T6 value6) -> void (with 4 less parameter)</returns>
        [Pure]
        public static Action<T5, T6> Partial<T1, T2, T3, T4, T5, T6>(
            this Action<T1, T2, T3, T4, T5, T6> action, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6) => action(value1, value2, value3, value4, value5, value6);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <returns>function of type (T4 value4, T5 value5, T6 value6) -> void (with 3 less parameter)</returns>
        [Pure]
        public static Action<T4, T5, T6> Partial<T1, T2, T3, T4, T5, T6>(
            this Action<T1, T2, T3, T4, T5, T6> action, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6) => action(value1, value2, value3, value4, value5, value6);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <returns>function of type (T3 value3, T4 value4, T5 value5, T6 value6) -> void (with 2 less parameter)</returns>
        [Pure]
        public static Action<T3, T4, T5, T6> Partial<T1, T2, T3, T4, T5, T6>(
            this Action<T1, T2, T3, T4, T5, T6> action, T1 value1, T2 value2) =>
                (value3, value4, value5, value6) => action(value1, value2, value3, value4, value5, value6);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) -> void (with 1 less parameter)</returns>
        [Pure]
        public static Action<T2, T3, T4, T5, T6> Partial<T1, T2, T3, T4, T5, T6>(
            this Action<T1, T2, T3, T4, T5, T6> action, T1 value1) =>
                (value2, value3, value4, value5, value6) => action(value1, value2, value3, value4, value5, value6);

        #endregion

        #region Partial<T1, T2, T3, T4, T5, T6, T7, void>
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <returns>function of type (T7 value7) -> void (with 6 less parameter)</returns>
        [Pure]
        public static Action<T7> Partial<T1, T2, T3, T4, T5, T6, T7>(
            this Action<T1, T2, T3, T4, T5, T6, T7> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7) => action(value1, value2, value3, value4, value5, value6, value7);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <returns>function of type (T6 value6, T7 value7) -> void (with 5 less parameter)</returns>
        [Pure]
        public static Action<T6, T7> Partial<T1, T2, T3, T4, T5, T6, T7>(
            this Action<T1, T2, T3, T4, T5, T6, T7> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7) => action(value1, value2, value3, value4, value5, value6, value7);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <returns>function of type (T5 value5, T6 value6, T7 value7) -> void (with 4 less parameter)</returns>
        [Pure]
        public static Action<T5, T6, T7> Partial<T1, T2, T3, T4, T5, T6, T7>(
            this Action<T1, T2, T3, T4, T5, T6, T7> action, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7) => action(value1, value2, value3, value4, value5, value6, value7);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <returns>function of type (T4 value4, T5 value5, T6 value6, T7 value7) -> void (with 3 less parameter)</returns>
        [Pure]
        public static Action<T4, T5, T6, T7> Partial<T1, T2, T3, T4, T5, T6, T7>(
            this Action<T1, T2, T3, T4, T5, T6, T7> action, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7) => action(value1, value2, value3, value4, value5, value6, value7);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <returns>function of type (T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) -> void (with 2 less parameter)</returns>
        [Pure]
        public static Action<T3, T4, T5, T6, T7> Partial<T1, T2, T3, T4, T5, T6, T7>(
            this Action<T1, T2, T3, T4, T5, T6, T7> action, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7) => action(value1, value2, value3, value4, value5, value6, value7);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) -> void (with 1 less parameter)</returns>
        [Pure]
        public static Action<T2, T3, T4, T5, T6, T7> Partial<T1, T2, T3, T4, T5, T6, T7>(
            this Action<T1, T2, T3, T4, T5, T6, T7> action, T1 value1) =>
                (value2, value3, value4, value5, value6, value7) => action(value1, value2, value3, value4, value5, value6, value7);

        #endregion

        #region Partial<T1, T2, T3, T4, T5, T6, T7, T8, void>
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <returns>function of type (T8 value8) -> void (with 7 less parameter)</returns>
        [Pure]
        public static Action<T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) =>
                (value8) => action(value1, value2, value3, value4, value5, value6, value7, value8);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <returns>function of type (T7 value7, T8 value8) -> void (with 6 less parameter)</returns>
        [Pure]
        public static Action<T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7, value8) => action(value1, value2, value3, value4, value5, value6, value7, value8);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <returns>function of type (T6 value6, T7 value7, T8 value8) -> void (with 5 less parameter)</returns>
        [Pure]
        public static Action<T6, T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7, value8) => action(value1, value2, value3, value4, value5, value6, value7, value8);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <returns>function of type (T5 value5, T6 value6, T7 value7, T8 value8) -> void (with 4 less parameter)</returns>
        [Pure]
        public static Action<T5, T6, T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7, value8) => action(value1, value2, value3, value4, value5, value6, value7, value8);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <returns>function of type (T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) -> void (with 3 less parameter)</returns>
        [Pure]
        public static Action<T4, T5, T6, T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7, value8) => action(value1, value2, value3, value4, value5, value6, value7, value8);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <returns>function of type (T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) -> void (with 2 less parameter)</returns>
        [Pure]
        public static Action<T3, T4, T5, T6, T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7, value8) => action(value1, value2, value3, value4, value5, value6, value7, value8);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) -> void (with 1 less parameter)</returns>
        [Pure]
        public static Action<T2, T3, T4, T5, T6, T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 value1) =>
                (value2, value3, value4, value5, value6, value7, value8) => action(value1, value2, value3, value4, value5, value6, value7, value8);

        #endregion

        #region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, void>
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <returns>function of type (T9 value9) -> void (with 8 less parameter)</returns>
        [Pure]
        public static Action<T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) =>
                (value9) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <returns>function of type (T8 value8, T9 value9) -> void (with 7 less parameter)</returns>
        [Pure]
        public static Action<T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) =>
                (value8, value9) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <returns>function of type (T7 value7, T8 value8, T9 value9) -> void (with 6 less parameter)</returns>
        [Pure]
        public static Action<T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7, value8, value9) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <returns>function of type (T6 value6, T7 value7, T8 value8, T9 value9) -> void (with 5 less parameter)</returns>
        [Pure]
        public static Action<T6, T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7, value8, value9) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <returns>function of type (T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) -> void (with 4 less parameter)</returns>
        [Pure]
        public static Action<T5, T6, T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7, value8, value9) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <returns>function of type (T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) -> void (with 3 less parameter)</returns>
        [Pure]
        public static Action<T4, T5, T6, T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7, value8, value9) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <returns>function of type (T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) -> void (with 2 less parameter)</returns>
        [Pure]
        public static Action<T3, T4, T5, T6, T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7, value8, value9) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) -> void (with 1 less parameter)</returns>
        [Pure]
        public static Action<T2, T3, T4, T5, T6, T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 value1) =>
                (value2, value3, value4, value5, value6, value7, value8, value9) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9);

        #endregion

        #region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, void>
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <returns>function of type (T10 value10) -> void (with 9 less parameter)</returns>
        [Pure]
        public static Action<T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) =>
                (value10) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <returns>function of type (T9 value9, T10 value10) -> void (with 8 less parameter)</returns>
        [Pure]
        public static Action<T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) =>
                (value9, value10) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <returns>function of type (T8 value8, T9 value9, T10 value10) -> void (with 7 less parameter)</returns>
        [Pure]
        public static Action<T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) =>
                (value8, value9, value10) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <returns>function of type (T7 value7, T8 value8, T9 value9, T10 value10) -> void (with 6 less parameter)</returns>
        [Pure]
        public static Action<T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7, value8, value9, value10) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <returns>function of type (T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) -> void (with 5 less parameter)</returns>
        [Pure]
        public static Action<T6, T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7, value8, value9, value10) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <returns>function of type (T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) -> void (with 4 less parameter)</returns>
        [Pure]
        public static Action<T5, T6, T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7, value8, value9, value10) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <returns>function of type (T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) -> void (with 3 less parameter)</returns>
        [Pure]
        public static Action<T4, T5, T6, T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7, value8, value9, value10) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <returns>function of type (T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) -> void (with 2 less parameter)</returns>
        [Pure]
        public static Action<T3, T4, T5, T6, T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7, value8, value9, value10) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) -> void (with 1 less parameter)</returns>
        [Pure]
        public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 value1) =>
                (value2, value3, value4, value5, value6, value7, value8, value9, value10) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);

        #endregion

        #region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, void>
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) -> void</param>
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
        /// <returns>function of type (T11 value11) -> void (with 10 less parameter)</returns>
        [Pure]
        public static Action<T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) =>
                (value11) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <returns>function of type (T10 value10, T11 value11) -> void (with 9 less parameter)</returns>
        [Pure]
        public static Action<T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) =>
                (value10, value11) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <returns>function of type (T9 value9, T10 value10, T11 value11) -> void (with 8 less parameter)</returns>
        [Pure]
        public static Action<T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) =>
                (value9, value10, value11) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <returns>function of type (T8 value8, T9 value9, T10 value10, T11 value11) -> void (with 7 less parameter)</returns>
        [Pure]
        public static Action<T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) =>
                (value8, value9, value10, value11) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <returns>function of type (T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) -> void (with 6 less parameter)</returns>
        [Pure]
        public static Action<T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7, value8, value9, value10, value11) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <returns>function of type (T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) -> void (with 5 less parameter)</returns>
        [Pure]
        public static Action<T6, T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7, value8, value9, value10, value11) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <returns>function of type (T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) -> void (with 4 less parameter)</returns>
        [Pure]
        public static Action<T5, T6, T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7, value8, value9, value10, value11) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <returns>function of type (T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) -> void (with 3 less parameter)</returns>
        [Pure]
        public static Action<T4, T5, T6, T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7, value8, value9, value10, value11) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <returns>function of type (T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) -> void (with 2 less parameter)</returns>
        [Pure]
        public static Action<T3, T4, T5, T6, T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7, value8, value9, value10, value11) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) -> void (with 1 less parameter)</returns>
        [Pure]
        public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 value1) =>
                (value2, value3, value4, value5, value6, value7, value8, value9, value10, value11) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);

        #endregion

        #region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, void>
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) -> void</param>
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
        /// <returns>function of type (T12 value12) -> void (with 11 less parameter)</returns>
        [Pure]
        public static Action<T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) =>
                (value12) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) -> void</param>
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
        /// <returns>function of type (T11 value11, T12 value12) -> void (with 10 less parameter)</returns>
        [Pure]
        public static Action<T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) =>
                (value11, value12) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <returns>function of type (T10 value10, T11 value11, T12 value12) -> void (with 9 less parameter)</returns>
        [Pure]
        public static Action<T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) =>
                (value10, value11, value12) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <returns>function of type (T9 value9, T10 value10, T11 value11, T12 value12) -> void (with 8 less parameter)</returns>
        [Pure]
        public static Action<T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) =>
                (value9, value10, value11, value12) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <returns>function of type (T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) -> void (with 7 less parameter)</returns>
        [Pure]
        public static Action<T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) =>
                (value8, value9, value10, value11, value12) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <returns>function of type (T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) -> void (with 6 less parameter)</returns>
        [Pure]
        public static Action<T7, T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7, value8, value9, value10, value11, value12) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <returns>function of type (T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) -> void (with 5 less parameter)</returns>
        [Pure]
        public static Action<T6, T7, T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7, value8, value9, value10, value11, value12) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <returns>function of type (T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) -> void (with 4 less parameter)</returns>
        [Pure]
        public static Action<T5, T6, T7, T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7, value8, value9, value10, value11, value12) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <returns>function of type (T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) -> void (with 3 less parameter)</returns>
        [Pure]
        public static Action<T4, T5, T6, T7, T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7, value8, value9, value10, value11, value12) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <returns>function of type (T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) -> void (with 2 less parameter)</returns>
        [Pure]
        public static Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7, value8, value9, value10, value11, value12) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) -> void (with 1 less parameter)</returns>
        [Pure]
        public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 value1) =>
                (value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);

        #endregion

        #region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, void>
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) -> void</param>
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
        /// <returns>function of type (T13 value13) -> void (with 12 less parameter)</returns>
        [Pure]
        public static Action<T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) =>
                (value13) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) -> void</param>
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
        /// <returns>function of type (T12 value12, T13 value13) -> void (with 11 less parameter)</returns>
        [Pure]
        public static Action<T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) =>
                (value12, value13) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) -> void</param>
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
        /// <returns>function of type (T11 value11, T12 value12, T13 value13) -> void (with 10 less parameter)</returns>
        [Pure]
        public static Action<T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) =>
                (value11, value12, value13) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <returns>function of type (T10 value10, T11 value11, T12 value12, T13 value13) -> void (with 9 less parameter)</returns>
        [Pure]
        public static Action<T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) =>
                (value10, value11, value12, value13) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <returns>function of type (T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) -> void (with 8 less parameter)</returns>
        [Pure]
        public static Action<T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) =>
                (value9, value10, value11, value12, value13) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <returns>function of type (T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) -> void (with 7 less parameter)</returns>
        [Pure]
        public static Action<T8, T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) =>
                (value8, value9, value10, value11, value12, value13) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <returns>function of type (T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) -> void (with 6 less parameter)</returns>
        [Pure]
        public static Action<T7, T8, T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7, value8, value9, value10, value11, value12, value13) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <returns>function of type (T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) -> void (with 5 less parameter)</returns>
        [Pure]
        public static Action<T6, T7, T8, T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7, value8, value9, value10, value11, value12, value13) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <returns>function of type (T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) -> void (with 4 less parameter)</returns>
        [Pure]
        public static Action<T5, T6, T7, T8, T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7, value8, value9, value10, value11, value12, value13) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <returns>function of type (T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) -> void (with 3 less parameter)</returns>
        [Pure]
        public static Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7, value8, value9, value10, value11, value12, value13) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <returns>function of type (T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) -> void (with 2 less parameter)</returns>
        [Pure]
        public static Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) -> void (with 1 less parameter)</returns>
        [Pure]
        public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 value1) =>
                (value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);

        #endregion

        #region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, void>
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) -> void</param>
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
        /// <returns>function of type (T14 value14) -> void (with 13 less parameter)</returns>
        [Pure]
        public static Action<T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) =>
                (value14) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) -> void</param>
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
        /// <returns>function of type (T13 value13, T14 value14) -> void (with 12 less parameter)</returns>
        [Pure]
        public static Action<T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) =>
                (value13, value14) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) -> void</param>
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
        /// <returns>function of type (T12 value12, T13 value13, T14 value14) -> void (with 11 less parameter)</returns>
        [Pure]
        public static Action<T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) =>
                (value12, value13, value14) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) -> void</param>
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
        /// <returns>function of type (T11 value11, T12 value12, T13 value13, T14 value14) -> void (with 10 less parameter)</returns>
        [Pure]
        public static Action<T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) =>
                (value11, value12, value13, value14) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <returns>function of type (T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) -> void (with 9 less parameter)</returns>
        [Pure]
        public static Action<T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) =>
                (value10, value11, value12, value13, value14) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <returns>function of type (T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) -> void (with 8 less parameter)</returns>
        [Pure]
        public static Action<T9, T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) =>
                (value9, value10, value11, value12, value13, value14) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <returns>function of type (T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) -> void (with 7 less parameter)</returns>
        [Pure]
        public static Action<T8, T9, T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) =>
                (value8, value9, value10, value11, value12, value13, value14) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <returns>function of type (T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) -> void (with 6 less parameter)</returns>
        [Pure]
        public static Action<T7, T8, T9, T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7, value8, value9, value10, value11, value12, value13, value14) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <returns>function of type (T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) -> void (with 5 less parameter)</returns>
        [Pure]
        public static Action<T6, T7, T8, T9, T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7, value8, value9, value10, value11, value12, value13, value14) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <returns>function of type (T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) -> void (with 4 less parameter)</returns>
        [Pure]
        public static Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7, value8, value9, value10, value11, value12, value13, value14) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <returns>function of type (T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) -> void (with 3 less parameter)</returns>
        [Pure]
        public static Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <returns>function of type (T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) -> void (with 2 less parameter)</returns>
        [Pure]
        public static Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) -> void (with 1 less parameter)</returns>
        [Pure]
        public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 value1) =>
                (value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);

        #endregion

        #region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, void>
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) -> void</param>
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
        /// <returns>function of type (T15 value15) -> void (with 14 less parameter)</returns>
        [Pure]
        public static Action<T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) =>
                (value15) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) -> void</param>
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
        /// <returns>function of type (T14 value14, T15 value15) -> void (with 13 less parameter)</returns>
        [Pure]
        public static Action<T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) =>
                (value14, value15) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) -> void</param>
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
        /// <returns>function of type (T13 value13, T14 value14, T15 value15) -> void (with 12 less parameter)</returns>
        [Pure]
        public static Action<T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) =>
                (value13, value14, value15) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) -> void</param>
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
        /// <returns>function of type (T12 value12, T13 value13, T14 value14, T15 value15) -> void (with 11 less parameter)</returns>
        [Pure]
        public static Action<T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) =>
                (value12, value13, value14, value15) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) -> void</param>
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
        /// <returns>function of type (T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) -> void (with 10 less parameter)</returns>
        [Pure]
        public static Action<T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) =>
                (value11, value12, value13, value14, value15) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <returns>function of type (T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) -> void (with 9 less parameter)</returns>
        [Pure]
        public static Action<T10, T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) =>
                (value10, value11, value12, value13, value14, value15) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <returns>function of type (T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) -> void (with 8 less parameter)</returns>
        [Pure]
        public static Action<T9, T10, T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) =>
                (value9, value10, value11, value12, value13, value14, value15) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <returns>function of type (T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) -> void (with 7 less parameter)</returns>
        [Pure]
        public static Action<T8, T9, T10, T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) =>
                (value8, value9, value10, value11, value12, value13, value14, value15) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <returns>function of type (T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) -> void (with 6 less parameter)</returns>
        [Pure]
        public static Action<T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7, value8, value9, value10, value11, value12, value13, value14, value15) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <returns>function of type (T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) -> void (with 5 less parameter)</returns>
        [Pure]
        public static Action<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7, value8, value9, value10, value11, value12, value13, value14, value15) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <returns>function of type (T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) -> void (with 4 less parameter)</returns>
        [Pure]
        public static Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <returns>function of type (T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) -> void (with 3 less parameter)</returns>
        [Pure]
        public static Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <returns>function of type (T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) -> void (with 2 less parameter)</returns>
        [Pure]
        public static Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) -> void (with 1 less parameter)</returns>
        [Pure]
        public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 value1) =>
                (value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);

        #endregion

        #region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, void>
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> void</param>
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
        /// <returns>function of type (T16 value16) -> void (with 15 less parameter)</returns>
        [Pure]
        public static Action<T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) =>
                (value16) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> void</param>
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
        /// <returns>function of type (T15 value15, T16 value16) -> void (with 14 less parameter)</returns>
        [Pure]
        public static Action<T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) =>
                (value15, value16) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> void</param>
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
        /// <returns>function of type (T14 value14, T15 value15, T16 value16) -> void (with 13 less parameter)</returns>
        [Pure]
        public static Action<T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) =>
                (value14, value15, value16) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> void</param>
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
        /// <returns>function of type (T13 value13, T14 value14, T15 value15, T16 value16) -> void (with 12 less parameter)</returns>
        [Pure]
        public static Action<T13, T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) =>
                (value13, value14, value15, value16) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> void</param>
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
        /// <returns>function of type (T12 value12, T13 value13, T14 value14, T15 value15, T16 value16) -> void (with 11 less parameter)</returns>
        [Pure]
        public static Action<T12, T13, T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) =>
                (value12, value13, value14, value15, value16) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> void</param>
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
        /// <returns>function of type (T11 value11, T12 value12, T13 value13, T14 value14, T15 value15, T16 value16) -> void (with 10 less parameter)</returns>
        [Pure]
        public static Action<T11, T12, T13, T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) =>
                (value11, value12, value13, value14, value15, value16) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <param name="value9">parameter 9 of type T9</param>
        /// <returns>function of type (T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15, T16 value16) -> void (with 9 less parameter)</returns>
        [Pure]
        public static Action<T10, T11, T12, T13, T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) =>
                (value10, value11, value12, value13, value14, value15, value16) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <param name="value8">parameter 8 of type T8</param>
        /// <returns>function of type (T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15, T16 value16) -> void (with 8 less parameter)</returns>
        [Pure]
        public static Action<T9, T10, T11, T12, T13, T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) =>
                (value9, value10, value11, value12, value13, value14, value15, value16) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <param name="value7">parameter 7 of type T7</param>
        /// <returns>function of type (T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15, T16 value16) -> void (with 7 less parameter)</returns>
        [Pure]
        public static Action<T8, T9, T10, T11, T12, T13, T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) =>
                (value8, value9, value10, value11, value12, value13, value14, value15, value16) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <param name="value6">parameter 6 of type T6</param>
        /// <returns>function of type (T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15, T16 value16) -> void (with 6 less parameter)</returns>
        [Pure]
        public static Action<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7, value8, value9, value10, value11, value12, value13, value14, value15, value16) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <param name="value5">parameter 5 of type T5</param>
        /// <returns>function of type (T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15, T16 value16) -> void (with 5 less parameter)</returns>
        [Pure]
        public static Action<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <param name="value4">parameter 4 of type T4</param>
        /// <returns>function of type (T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15, T16 value16) -> void (with 4 less parameter)</returns>
        [Pure]
        public static Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <param name="value3">parameter 3 of type T3</param>
        /// <returns>function of type (T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15, T16 value16) -> void (with 3 less parameter)</returns>
        [Pure]
        public static Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <param name="value2">parameter 2 of type T2</param>
        /// <returns>function of type (T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15, T16 value16) -> void (with 2 less parameter)</returns>
        [Pure]
        public static Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
        
        /// <summary>
        /// Partial execution
        /// </summary>
        /// <param name="action">function from target Action of type (T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16) -> void</param>
        /// <param name="value1">parameter 1 of type T1</param>
        /// <returns>function of type (T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15, T16 value16) -> void (with 1 less parameter)</returns>
        [Pure]
        public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 value1) =>
                (value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16) => action(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);

        #endregion
    }
}