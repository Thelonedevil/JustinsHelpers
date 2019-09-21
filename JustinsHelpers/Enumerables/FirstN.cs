using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustinsHelpers.Enumerables.FirstN
{
    public static class Helper
    {
        /// <summary>
        /// Returns a tuple containsing the first two elements in the sequence, filtered by a predicate.
        /// </summary>
        /// <typeparam name="TModel">The Type that the sequence contains.</typeparam>
        /// <param name="source">The <see cref="IEnumerable{TModel}"> to get the first two elements of.</param>
        /// <param name="predicate">Predicate</param>
        /// <returns>A tuple containsing the first 2 elements in the sequence, filtered by a predicate</returns>
        /// <exception cref="ArgumentException">Thrown when the sequence has less than two elements</exception>
        /// <seealso cref="FirstTwo{TModel}(IEnumerable{TModel})"/>
        /// <seealso cref="FirstTwoOrDefault{TModel}(IEnumerable{TModel})"/>
        /// <seealso cref="FirstTwoOrDefault{TModel}(IEnumerable{TModel}, Func{TModel, bool})"/>
        public static (TModel First, TModel Second) FirstTwo<TModel>(this IEnumerable<TModel> source, Func<TModel, bool> predicate)
        {
            var list = source.Where(predicate).ToList();
            if (list.Count < 2)
            {
                throw new ArgumentException($"{nameof(source)} needs 2 or more elements", nameof(source));
            }
            return (list[0], list[1]);
        }
        /// <summary>
        /// Returns a tuple containsing the first 2 elements in the sequence.
        /// </summary>
        /// <typeparam name="TModel">The Type that the sequence contains</typeparam>
        /// <param name="source">The Sequence</param>
        /// <returns>A tuple containsing the first 2 elements in the sequence</returns>
        /// <exception cref="ArgumentException">Thrown when the sequence has less than two elements</exception>
        /// <seealso cref="FirstTwo{TModel}(IEnumerable{TModel}, Func{TModel, bool})"/>
        /// <seealso cref="FirstTwoOrDefault{TModel}(IEnumerable{TModel})"/>
        /// <seealso cref="FirstTwoOrDefault{TModel}(IEnumerable{TModel}, Func{TModel, bool})"/>
        public static (TModel First, TModel Second) FirstTwo<TModel>(this IEnumerable<TModel> source)
        {
            return source.FirstTwo(_ => true);
        }
        /// <summary>
        /// Returns a tuple containsing the first 2 elements in the sequence, filtered by a predicate.
        /// Supplies the default value if sequence has less than 2 elements.
        /// </summary>
        /// <typeparam name="TModel">The Type that the sequence contains</typeparam>
        /// <param name="source">The Sequence</param>
        /// <param name="predicate">Optional predicate</param>
        /// <returns>A tuple containsing the first 2 elements in the sequence, filtered by a predicate</returns>
        /// <seealso cref="FirstTwo{TModel}(IEnumerable{TModel})"/>
        /// <seealso cref="FirstTwo{TModel}(IEnumerable{TModel}, Func{TModel, bool})"/>
        /// <seealso cref="FirstTwoOrDefault{TModel}(IEnumerable{TModel})"/>
        public static (TModel First, TModel Second) FirstTwoOrDefault<TModel>(this IEnumerable<TModel> source, Func<TModel, bool> predicate)
        {
            var list = source.Where(predicate).ToList();
            if (list.Count == 0)
            {
                return (default, default);
            }
            if (list.Count == 1)
            {
                return (list[0], default);
            }
            return (list[0], list[1]);
        }
        /// <summary>
        /// Returns a tuple containsing the first 2 elements in the sequence.
        /// Supplies the default value if sequence has less than 2 elements.
        /// </summary>
        /// <typeparam name="TModel">The Type that the sequence contains</typeparam>
        /// <param name="source">The Sequence</param>
        /// <returns>A tuple containsing the first 2 elements in the sequence, optionionally filtered by a predicate</returns>
        /// <seealso cref="FirstTwo{TModel}(IEnumerable{TModel})"/>
        /// <seealso cref="FirstTwo{TModel}(IEnumerable{TModel}, Func{TModel, bool})"/>
        /// <seealso cref="FirstTwoOrDefault{TModel}(IEnumerable{TModel})"/>
        public static (TModel First, TModel Second) FirstTwoOrDefault<TModel>(this IEnumerable<TModel> source)
        {
            return source.FirstTwoOrDefault(_ => true);
        }
        public static (TModel First, TModel Second, TModel Third) FirstThree<TModel>(this IEnumerable<TModel> source, Func<TModel, bool> predicate = null)
        {
            var list = source.Where(predicate ?? (_ => true)).ToList();
            if (list.Count < 3)
            {
                throw new ArgumentException($"{nameof(source)} needs 3 or more elements", nameof(source));
            }
            return (list[0], list[1], list[2]);
        }
        public static (TModel First, TModel Second, TModel Third) FirstThreeOrDefault<TModel>(this IEnumerable<TModel> source, Func<TModel, bool> predicate = null)

        {
            var list = source.Where(predicate ?? (_ => true)).ToList();
            if (list.Count == 0)
            {
                return (default, default, default);
            }
            if (list.Count == 1)
            {
                return (list[0], default, default);
            }
            if (list.Count == 2)
            {
                return (list[0], list[1], default);
            }
            return (list[0], list[1], list[2]);
        }
        public static (TModel First, TModel Second, TModel Third, TModel Fouth) FirstFour<TModel>(this IEnumerable<TModel> source, Func<TModel, bool> predicate = null)
        {
            var list = source.Where(predicate ?? (_ => true)).ToList();
            if (list.Count < 4)
            {
                throw new ArgumentException($"{nameof(source)} needs 4 or more elements", nameof(source));
            }
            return (list[0], list[1], list[2], list[3]);
        }
        public static (TModel First, TModel Second, TModel Third, TModel Fouth) FirstFourOrDefault<TModel>(this IEnumerable<TModel> source, Func<TModel, bool> predicate = null)

        {
            var list = source.Where(predicate ?? (_ => true)).ToList();
            if (list.Count == 0)
            {
                return (default, default, default, default);
            }
            if (list.Count == 1)
            {
                return (list[0], default, default, default);
            }
            if (list.Count == 2)
            {
                return (list[0], list[1], default, default);
            }
            if (list.Count == 3)
            {
                return (list[0], list[1], list[2], default);
            }
            return (list[0], list[1], list[2], list[3]);
        }

        public static (TModel First, TModel Second, TModel Third, TModel Fouth, TModel Fifth) FirstFive<TModel>(this IEnumerable<TModel> source, Func<TModel, bool> predicate = null)
        {
            var list = source.Where(predicate ?? (_ => true)).ToList();
            if (list.Count < 5)
            {
                throw new ArgumentException($"{nameof(source)} needs 5 or more elements", nameof(source));
            }
            return (list[0], list[1], list[2], list[3], list[4]);
        }
        public static (TModel First, TModel Second, TModel Third, TModel Fouth, TModel Fifth) FirstFiveOrDefault<TModel>(this IEnumerable<TModel> source, Func<TModel, bool> predicate = null)

        {
            var list = source.Where(predicate ?? (_ => true)).ToList();
            if (list.Count == 0)
            {
                return (default, default, default, default, default);
            }
            if (list.Count == 1)
            {
                return (list[0], default, default, default, default);
            }
            if (list.Count == 2)
            {
                return (list[0], list[1], default, default, default);
            }
            if (list.Count == 3)
            {
                return (list[0], list[1], list[2], default, default);
            }
            if (list.Count == 4)
            {
                return (list[0], list[1], list[2], list[3], default);
            }
            return (list[0], list[1], list[2], list[3], list[4]);
        }

        public static (TModel First, TModel Second, TModel Third, TModel Fouth, TModel Fifth, TModel Sixth) FirstSix<TModel>(this IEnumerable<TModel> source, Func<TModel, bool> predicate = null)
        {
            var list = source.Where(predicate ?? (_ => true)).ToList();
            if (list.Count < 6)
            {
                throw new ArgumentException($"{nameof(source)} needs 6 or more elements", nameof(source));
            }
            return (list[0], list[1], list[2], list[3], list[4], list[5]);
        }
        public static (TModel First, TModel Second, TModel Third, TModel Fouth, TModel Fifth, TModel Sixth) FirstSixOrDefault<TModel>(this IEnumerable<TModel> source, Func<TModel, bool> predicate = null)

        {
            var list = source.Where(predicate ?? (_ => true)).ToList();
            if (list.Count == 0)
            {
                return (default, default, default, default, default, default);
            }
            if (list.Count == 1)
            {
                return (list[0], default, default, default, default, default);
            }
            if (list.Count == 2)
            {
                return (list[0], list[1], default, default, default, default);
            }
            if (list.Count == 3)
            {
                return (list[0], list[1], list[2], default, default, default);
            }
            if (list.Count == 4)
            {
                return (list[0], list[1], list[2], list[3], default, default);
            }
            if (list.Count == 5)
            {
                return (list[0], list[1], list[2], list[3], list[4], default);
            }
            return (list[0], list[1], list[2], list[3], list[4], list[5]);
        }
        public static (TModel First, TModel Second, TModel Third, TModel Fouth, TModel Fifth, TModel Sixth, TModel Seventh) FirstSeven<TModel>(this IEnumerable<TModel> source, Func<TModel, bool> predicate = null)
        {
            var list = source.Where(predicate ?? (_ => true)).ToList();
            if (list.Count < 7)
            {
                throw new ArgumentException($"{nameof(source)} needs 7 or more elements", nameof(source));
            }
            return (list[0], list[1], list[2], list[3], list[4], list[5], list[6]);
        }
        public static (TModel First, TModel Second, TModel Third, TModel Fouth, TModel Fifth, TModel Sixth, TModel Seventh) FirstSevenOrDefault<TModel>(this IEnumerable<TModel> source, Func<TModel, bool> predicate = null)

        {
            var list = source.Where(predicate ?? (_ => true)).ToList();
            if (list.Count == 0)
            {
                return (default, default, default, default, default, default, default);
            }
            if (list.Count == 1)
            {
                return (list[0], default, default, default, default, default, default);
            }
            if (list.Count == 2)
            {
                return (list[0], list[1], default, default, default, default, default);
            }
            if (list.Count == 3)
            {
                return (list[0], list[1], list[2], default, default, default, default);
            }
            if (list.Count == 4)
            {
                return (list[0], list[1], list[2], list[3], default, default, default);
            }
            if (list.Count == 5)
            {
                return (list[0], list[1], list[2], list[3], list[4], default, default);
            }
            if (list.Count == 6)
            {
                return (list[0], list[1], list[2], list[3], list[4], list[5], default);
            }
            return (list[0], list[1], list[2], list[3], list[4], list[5], list[6]);
        }
    }
}
