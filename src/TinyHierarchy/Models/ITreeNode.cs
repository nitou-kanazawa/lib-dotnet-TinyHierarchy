using System;
using System.Collections.Generic;

namespace TinyHierarchy {
    /// <summary>
    /// ツリーノードのインターフェース（読み取り専用）。
    /// </summary>
    /// <typeparam name="T">ノードが保持する値の型</typeparam>
    public interface ITreeNode<T> {

        /// <summary>
        /// 親ノード（nullの場合はルート）
        /// </summary>
        ITreeNode<T>? Parent { get; }

        /// <summary>
        /// 子ノードの列挙（読み取り専用）
        /// </summary>
        IEnumerable<ITreeNode<T>> Children { get; }

        /// <summary>
        /// ノードが保持する値
        /// </summary>
        T Value { get; set; }
    }
}
