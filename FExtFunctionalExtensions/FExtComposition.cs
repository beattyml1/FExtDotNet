using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FExtFunctionalExtensions {
  public static class FExtEnumerableExtensions {
    public static TOut Transform<TIn, TOut>(this TIn value, Func<TIn, TOut> f1) {
      return f1(value);
    }
    public static TOut Transform<TIn, TP1, TOut>(this TIn value, Func<TIn, TP1, TOut> f1, TP1 p1) {
      return f1(value, p1);
    }
    public static TOut Transform<TIn, TP1, TP2, TOut>(this TIn value, Func<TIn, TP1, TOut> f1, TP1 p1, TP2 p2) {
      return f1(value, p1, p2);
    }
    public static TOut Transform<TIn, TP1, TP2, TP3, TOut>(this TIn value, Func<TIn, TP1, TOut> f1, TP1 p1, TP2 p2, TP3 p3) {
      return f1(value, p1, p2, p3);
    }

    public static TOut _<TIn, TOut>(this TIn value, Func<TIn, TOut> f1) {
      return f1(value);
    }
    public static TOut _<TIn, TP1, TOut>(this TIn value, Func<TIn, TP1, TOut> f1, TP1 p1) {
      return f1(value, p1);
    }
    public static TOut _<TIn, TP1, TP2, TOut>(this TIn value, Func<TIn, TP1, TOut> f1, TP1 p1, TP2 p2) {
      return f1(value, p1, p2);
    }
    public static TOut _<TIn, TP1, TP2, TP3, TOut>(this TIn value, Func<TIn, TP1, TOut> f1, TP1 p1, TP2 p2, TP3 p3) {
      return f1(value, p1, p2, p3);
    }

    public static TOut Transform<TIn, TOut>(this TIn value, Func<TIn, T1> f1, Func<T1, TOut> f2) {
      return f2(f1(value));
    }
    public static TOut Transform<TIn, TOut>(this TIn value, Func<TIn, T1> f1, Func<T1, T2> f2, Func<T2, TOut> f3) {
      return f3(f2(f1(value)));
    }
    public static TOut Transform<TIn, TOut>(this TIn value, Func<TIn, T1> f1, Func<T1, T2> f2, Func<T2, T3> f3, Func<T3, TOut> f4) {
      return f4(f3(f2(f1(value))));
    }

    // Parameterize
    public static Func<TIn, TP1, TOut> Parameterize<TIn, TOut>(this Func<TIn, TP1, TOut> func, TP1 p1) {
      return (TIn input) => func(input, p1);
    }
    public static Func<TIn, TP1, TOut> Parameterize<TIn, TOut>(this Func<TIn, TP1, TOut> func, TP1 p1) {
      return (TIn input) => func(input, p1);
    }
    public static Func<TIn, TP1, TP2, TOut> Parameterize<TIn, TOut>(this Func<TIn, TP1, TP2, TOut> func, TP1 p1, TP2 p2) {
      return (TIn input) => func(input, p1, p2);
    }
    public static Func<TIn, TP1, TP2, TP3 TOut> Parameterize<TIn, TOut>(this Func<TIn, TP1, TP2, TP3, TOut> func, TP1 p1, TP2 p2, TP3 p3) {
      return (TIn input) => func(input, p1, p2, p3);
    }
    public static Func<TIn, TP1, TP2, TP3, TP4, TOut> Parameterize<TIn, TOut>(this Func<TIn, TP1, TP2, TP3, TOut> func, TP1 p1, TP2 p2, TP3 p3, TP4 p4) {
      return (TIn input) => func(input, p1, p2, p3, p4);
    }

    // Compose
    public static Func<TIn, TMid, TOut> Compose<TIn, TOut>(this Func<TIn, TMid> first, Func<TMid, TOut> second) {
      return (TIn input) => input.Transform(first).Transform(second);
    }
    public static Func<TIn, TMid, TOut> __<TIn, TOut>(this Func<TIn, TMid> first, Func<TMid, TOut> second) {
      return (TIn input) => input.Transform(first).Transform(second);
    }

    // Into
    public static T Into<T>(this T inputValue, out T outputVariable) {
      return outputVariable = inputValue;
    }
  }
}
