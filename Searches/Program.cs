using Searches;
using System.Diagnostics;

Stopwatch stopwatch = new Stopwatch();

// BFS Search

Console.WriteLine("BFS Search\n");

Node<string> rootNode = new Node<string>("A");
Node<string> bNode = new Node<string>("B");
Node<string> cNode = new Node<string>("C");
Node<string> dNode = new Node<string>("D");
Node<string> eNode = new Node<string>("E");
Node<string> fNode = new Node<string>("F");
Node<string> gNode = new Node<string>("G");
Node<string> hNode = new Node<string>("H");
Node<string> iNode = new Node<string>("I");
Node<string> jNode = new Node<string>("J");
Node<string> kNode = new Node<string>("K");
Node<string> lNode = new Node<string>("L");
Node<string> mNode = new Node<string>("M");
Node<string> nNode = new Node<string>("N");
Node<string> oNode = new Node<string>("O");
Node<string> pNode = new Node<string>("P");

rootNode.AddChild(bNode);
rootNode.AddChild(cNode);
rootNode.AddChild(dNode);

bNode.AddChild(eNode);
bNode.AddChild(fNode);

cNode.AddChild(gNode);
cNode.AddChild(hNode);
cNode.AddChild(iNode);
cNode.AddChild(jNode);

dNode.AddChild(kNode);
dNode.AddChild(lNode);

kNode.AddChild(mNode);
lNode.AddChild(mNode);

eNode.AddChild(nNode);
fNode.AddChild(nNode);

gNode.AddChild(oNode);
hNode.AddChild(oNode);
iNode.AddChild(oNode);
jNode.AddChild(oNode);

nNode.AddChild(pNode);
oNode.AddChild(pNode);
mNode.AddChild(pNode);


BFSSearch<string> bFSSearch = new BFSSearch<string>();
Search<string>.HasFoundItem += (node) => Console.WriteLine("Item found: " + node.Value + "\n");
Search<string>.HasNotFoundItem += (str) => Console.WriteLine("Item not found: " + str + "\n");
Search<string>.HasVisitedNode += (node) => Console.WriteLine("Visited node: " + node.Value + "\n");

stopwatch.Start();
bFSSearch.TryFind(rootNode, "P", out Node<string>? result);
stopwatch.Stop();
Console.WriteLine("Time elapsed: " + stopwatch.Elapsed + "\n\n");

// A* Search using BFS heuristic

Console.WriteLine("A* Search using BFS heuristic\n");

AStarNode<string> aStarRootNode = new AStarNode<string>(rootNode, 0);
AStarNode<string> aStarBNode = new AStarNode<string>(bNode, 5);
AStarNode<string> aStarCNode = new AStarNode<string>(cNode, 1);
AStarNode<string> aStarDNode = new AStarNode<string>(dNode, 3);
AStarNode<string> aStarENode = new AStarNode<string>(eNode, 4);
AStarNode<string> aStarFNode = new AStarNode<string>(fNode, 6);
AStarNode<string> aStarGNode = new AStarNode<string>(gNode, 3);
AStarNode<string> aStarHNode = new AStarNode<string>(hNode, 2);
AStarNode<string> aStarINode = new AStarNode<string>(iNode, 1);
AStarNode<string> aStarJNode = new AStarNode<string>(jNode, 3);
AStarNode<string> aStarKNode = new AStarNode<string>(kNode, 2);
AStarNode<string> aStarLNode = new AStarNode<string>(lNode, 3);
AStarNode<string> aStarMNode = new AStarNode<string>(mNode, 4);
AStarNode<string> aStarNNode = new AStarNode<string>(nNode, 2);
AStarNode<string> aStarONode = new AStarNode<string>(oNode, 1);
AStarNode<string> aStarPNode = new AStarNode<string>(pNode, 0);


aStarRootNode.AddChild(aStarBNode);
aStarRootNode.AddChild(aStarCNode);
aStarRootNode.AddChild(aStarDNode);

aStarBNode.AddChild(aStarENode);
aStarBNode.AddChild(aStarFNode);

aStarCNode.AddChild(aStarGNode);
aStarCNode.AddChild(aStarHNode);
aStarCNode.AddChild(aStarINode);
aStarCNode.AddChild(aStarJNode);

aStarDNode.AddChild(aStarKNode);
aStarDNode.AddChild(aStarLNode);

aStarKNode.AddChild(aStarMNode);
aStarLNode.AddChild(aStarMNode);

aStarENode.AddChild(aStarNNode);
aStarFNode.AddChild(aStarNNode);

aStarGNode.AddChild(aStarONode);
aStarHNode.AddChild(aStarONode);
aStarINode.AddChild(aStarONode);
aStarJNode.AddChild(aStarONode);

aStarNNode.AddChild(aStarPNode);
aStarONode.AddChild(aStarPNode);
aStarMNode.AddChild(aStarPNode);

AStarSearch<string> aStarSearch = new AStarSearch<string>(HeuristicType.BFS);

stopwatch.Restart();
aStarSearch.TryFind(aStarRootNode, "P", out Node<string>? aStarResult);
stopwatch.Stop();
Console.WriteLine("Time elapsed: " + stopwatch.Elapsed + "\n\n");