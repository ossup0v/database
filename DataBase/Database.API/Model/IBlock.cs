using System;
using System.Collections.Generic;
using System.Text;

namespace Database.API
{
    public interface IBlockDatabase
    {
        int BlockHeaderSize { get; }

        int BlockContentSize { get; set; }

        int BlockSize { get; set; }

        IBlock Find(uint blockId);

        IBlock CreateNew();
    }

    public interface IBlock : IDisposable
    {
        /// <summary>
        /// Id for block must be unique
        /// </summary>
        uint Id { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        int GetHeader(int field);

        /// <summary>
        /// Change the value of specified header
        /// </summary>
        /// <param name="field">Field to change.</param>
        /// <param name="value">Value for which changes.</param>
        /// <returns></returns>
        int SetHeader(int field, long value);

        /// <summary>
        /// Read content of source block (src)
        /// into gived buffer (dts)
        /// </summary>
        /// <param name="dst">Data storage buffer.</param>
        /// <param name="dstOffset"></param>
        /// <param name="srcOffset"></param>
        /// <param name="count"></param>
        void Read(byte[] dst, int dstOffset, int srcOffset, int count);

        /// <summary>
        /// Write content of given buffer (src) into this buffer (dts)
        /// </summary>
        /// <param name="src">Source buffer.</param>
        /// <param name="dstOffset"></param>
        /// <param name="srcOffset"></param>
        /// <param name="count"></param>
        void Write(byte[] src, int dstOffset, int srcOffset, int count);
    }

    public interface IIndex<K, V>
    {
        /// <summary>
        /// Create new entry in that index maps key K to value V.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="value">Value.</param>
        void Insert(K key, V value);

        /// <summary>
        /// Findig an entry by key.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <returns>Entry.</returns>
        Tuple<K, V> Get(K key);

        /// <summary>
        /// Find all entries that contain a key larger than or equal to specified key.
        /// </summary>
        IEnumerable<Tuple<K, V>> LargerThanOrEqualTo(K key);

        /// <summary>
        /// Find all entries that contain a key larger than specified key.
        /// </summary>
        IEnumerable<Tuple<K, V>> LargerThan(K key);

        /// <summary>
        /// Find all entries that contain a key less than or equal specified key.
        /// </summary>
        IEnumerable<Tuple<K, V>> LessThanOrEqualTo(K key);

        /// <summary>
        /// Find all entries that contain a key less than specified key.
        /// </summary>
        IEnumerable<Tuple<K, V>> LessThan(K key);

        /// <summary>
        /// Delete an entry from this index, optionally use specified IComparer to compare values.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="value">Value.</param>
        /// <param name="valueComparer">Value comparer; Default value is Comparer[k].Default</param>
        /// <returns>Result of attempted action.</returns>
        bool Delete(K key, V value, IComparer<V> valueComparer = null);

        /// <summary>
        /// Delete all entries of given key
        /// </summary>
        /// <param name="key">Key.</param>
        /// <returns>Result of attempted action.</returns>
        bool Delete(K key);
    }
}
