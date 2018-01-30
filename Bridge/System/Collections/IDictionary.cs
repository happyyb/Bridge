using System.Collections.Generic;
using Bridge;

namespace System.Collections
{
    [External]
    [Unbox(true)]
    [Convention(Target = ConventionTarget.Member, Member = ConventionMember.Method, Notation = Notation.LowerCamelCase)]
    [Reflectable]
    public interface IDictionary : ICollection, IBridgeClass
    {
        [AccessorsIndexer]
        object this[object key]
        {
            [Name("getItem")]
            get;
            [Name("setItem")]
            set;
        }

        ICollection Keys
        {
            get;
        }

        ICollection Values
        {
            get;
        }

        /// <summary>
        /// Returns whether this dictionary contains a particular key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        bool Contains(Object key);

        /// <summary>
        /// Returns an System.Collections.IDictionaryEnumerator object for the System.Collections.IDictionary
        /// object.
        /// </summary>
        /// <returns>
        /// An System.Collections.IDictionaryEnumerator object for the System.Collections.IDictionary
        /// object.
        /// </returns>
        new IDictionaryEnumerator GetEnumerator();

        /// <summary>
        /// Adds a key-value pair to the dictionary.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        void Add(Object key, Object value);

        /// <summary>
        /// Gets a value indicating whether the System.Collections.IDictionary object is
        /// read-only.
        /// </summary>
        /// <returns>
        /// true if the System.Collections.IDictionary object is read-only; otherwise, false.
        /// </returns>
        bool IsReadOnly
        {
            get;
        }

        /// <summary>
        /// Gets a value indicating whether the System.Collections.IDictionary object has
        /// a fixed size.
        /// </summary>
        /// <returns>
        /// true if the System.Collections.IDictionary object has a fixed size; otherwise,
        /// false.
        /// </returns>
        bool IsFixedSize { get; }

        /// <summary>
        /// Removes a particular key from the dictionary.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        bool Remove(Object key);
    }
}