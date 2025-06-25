using System;
using System.Collections.Generic;

namespace TinyHierarchy {

    /// <summary>
    /// ツリーノードの実装クラス。
    /// </summary>
    /// <typeparam name="T">ノード型（自身の型）</typeparam>
    public class TreeNode<T> : ITreeNode<T> {

        internal TreeNode<T>? _parent;
        internal readonly List<TreeNode<T>> _children = new();

        /// <inheritdoc/>
        public ITreeNode<T>? Parent => _parent;

        /// <inheritdoc/>
        public IEnumerable<ITreeNode<T>> Children => _children;

        /// <inheritdoc/>
        public T Value { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="value">ノードが保持する値</param>
        public TreeNode(T value) {
            Value = value;
        }

    }


    public static class TreeNodeExtensions {

        public static TreeNode<T> AddChild<T>(this TreeNode<T> self, TreeNode<T> child) {
            self._children.Add(child);
            child._parent = self;
            return child;
        }

        public static TreeNode<T> RemoveChild<T>(this TreeNode<T> self, TreeNode<T> child) {
            self._children.Remove(child);
            child._parent = null;
            return self;
        }

        public static TreeNode<T> MoveTo<T>(this TreeNode<T> self, TreeNode<T> newParent) {

            self._parent?.RemoveChild(self);
            newParent.AddChild(self);
            return self;
        }

    }
}
