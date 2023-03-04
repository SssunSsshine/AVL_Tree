# AVL_Tree
Разработать обобщенный класс Tree<T> – класс для описания сбалансированного дерева.
ITree <T>: IEnumerable<T> – базовый интерфейс для всех сбаланси-рованных деревьев;
o методы:
 void Add (T node);
 void Clear();
 bool Contains (T node);
 void Remove(T node);
o свойства:
 int Count;
 bool isEmpty;
 IEnumerable<T> nodes;

TreeException – класс, описывающий исключения, которые могут происходить в ходе работы со сбалансированным деревом (также можно написать ряд наследников от TreeException);

ArrayTree < T>: ITree < T > – класс сбалансированного дерева на ос-нове массива;

LinkedTree < T >: ITree < T > – класс сбалансированного дерева на ос-нове связного списка;

UnmutableTree < T >: ITree < T > – класс неизменяющегося сбаланси-рованного дерева, является оберткой над любым существующим деревом (должен кидаться исключениями на вызов любого метода, изменяющего дерево);

TreeUtils – класс различных операций над сбалансированным дере-вом;
o методы:
 static bool Exists< T >(ITree < T >, CheckDelegate< T >);
 static ITree < T > FindAll< T >(ITree < T >, CheckDelegate<T>,TreeConstructorDelegate< T >);
 static void ForEach(ITree < T >, ActionDelegate< T >);
 static bool CheckForAll< T >(ITree < T >, CheckDelegate<>);
o свойства:
 static readonly TreeConstructorDelegate< T > ArrayTreeConstructor;
 static readonly TreeConstructorDelegate< T > LinkedTreeConstructor;
Также необходимо разработать серию примеров, демонстрирующих основные аспекты работы с данной библиотекой сбалансированных деревьев.
