using System;
using TinyHierarchy;

namespace TinyHierarchy.Sample {
    class Program {
        static void Main(string[] args) {
            // サンプル：TreeNodeの基本操作
            var root = new TreeNode<string>("root");
            var child1 = new TreeNode<string>("child1");
            var child2 = new TreeNode<string>("child2");
            var grandchild = new TreeNode<string>("grandchild");

            // 子の追加
            root.AddChild(child1)
                .AddChild(child2);
            child1.AddChild(grandchild);

            Console.WriteLine($"root: {root.Value}");
            foreach (var child in root.Children) {
                Console.WriteLine($"  child: {child.Value}");
                foreach (var grand in child.Children) {
                    Console.WriteLine($"    grandchild: {grand.Value}");
                }
            }

            // ノードの移動
            grandchild.MoveTo(child2);
            Console.WriteLine("\n--- grandchildをchild2の子に移動 ---");
            foreach (var child in root.Children) {
                Console.WriteLine($"  child: {child.Value}");
                foreach (var grand in child.Children) {
                    Console.WriteLine($"    grandchild: {grand.Value}");
                }
            }

            // 子の削除
            root.RemoveChild(child1);
            Console.WriteLine("\n--- child1を削除 ---");
            foreach (var child in root.Children) {
                Console.WriteLine($"  child: {child.Value}");
            }
        }
    }
}
