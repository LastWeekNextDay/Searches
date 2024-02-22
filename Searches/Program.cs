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

/*AStarNode<string> aStarRootNode = new AStarNode<string>(rootNode, 0);
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
AStarNode<string> aStarPNode = new AStarNode<string>(pNode, 0);*/




/*aStarRootNode.AddChild(aStarBNode);
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
aStarMNode.AddChild(aStarPNode);*/

Node<string> AradNode = new Node<string>("Arad");
Node<string> ZerindNode = new Node<string>("Zerind");
Node<string> OradeaNode = new Node<string>("Oradea");
Node<string> SibiuNode = new Node<string>("Sibiu");
Node<string> TimisoaraNode = new Node<string>("Timisoara");
Node<string> LugojNode = new Node<string>("Lugoj");
Node<string> MehadiaNode = new Node<string>("Mehadia");
Node<string> DobretaNode = new Node<string>("Dobreta");
Node<string> CraiovaNode = new Node<string>("Craiova");
Node<string> RimnicuVilceaNode = new Node<string>("Rimnicu Vilcea");
Node<string> FagarasNode = new Node<string>("Fagaras");
Node<string> PitestiNode = new Node<string>("Pitesti");
Node<string> BucharestNode = new Node<string>("Bucharest");
Node<string> GiurgiuNode = new Node<string>("Giurgiu");
Node<string> UrziceniNode = new Node<string>("Urziceni");
Node<string> HirsovaNode = new Node<string>("Hirsova");
Node<string> EforieNode = new Node<string>("Eforie");
Node<string> VasluiNode = new Node<string>("Vaslui");
Node<string> IasiNode = new Node<string>("Iasi");
Node<string> NeamtNode = new Node<string>("Neamt");

AStarNode<string> Arad = new AStarNode<string>(AradNode, 0);
AStarNode<string> Zerind = new AStarNode<string>(ZerindNode, 374);
AStarNode<string> Oradea = new AStarNode<string>(OradeaNode, 380);
AStarNode<string> Sibiu = new AStarNode<string>(SibiuNode, 253);
AStarNode<string> Timisoara = new AStarNode<string>(TimisoaraNode, 329);
AStarNode<string> Lugoj = new AStarNode<string>(LugojNode, 244);
AStarNode<string> Mehadia = new AStarNode<string>(MehadiaNode, 241);
AStarNode<string> Dobreta = new AStarNode<string>(DobretaNode, 242);
AStarNode<string> Craiova = new AStarNode<string>(CraiovaNode, 160);
AStarNode<string> RimnicuVilcea = new AStarNode<string>(RimnicuVilceaNode, 193);
AStarNode<string> Fagaras = new AStarNode<string>(FagarasNode, 178);
AStarNode<string> Pitesti = new AStarNode<string>(PitestiNode, 98);
AStarNode<string> Bucharest = new AStarNode<string>(BucharestNode, 0);
AStarNode<string> Giurgiu = new AStarNode<string>(GiurgiuNode, 77);
AStarNode<string> Urziceni = new AStarNode<string>(UrziceniNode, 80);
AStarNode<string> Hirsova = new AStarNode<string>(HirsovaNode, 151);
AStarNode<string> Eforie = new AStarNode<string>(EforieNode, 161);
AStarNode<string> Vaslui = new AStarNode<string>(VasluiNode, 199);
AStarNode<string> Iasi = new AStarNode<string>(IasiNode, 226);
AStarNode<string> Neamt = new AStarNode<string>(NeamtNode, 234);

Arad.AddChild(Zerind);
Arad.AddChild(Timisoara);
Arad.AddChild(Sibiu);

Zerind.AddChild(Arad);
Timisoara.AddChild(Arad);
Sibiu.AddChild(Arad);


Zerind.AddChild(Oradea);

Oradea.AddChild(Zerind);

Oradea.AddChild(Sibiu);

Sibiu.AddChild(Oradea);

Timisoara.AddChild(Lugoj);

Lugoj.AddChild(Timisoara);

Lugoj.AddChild(Mehadia);

Mehadia.AddChild(Lugoj);

Mehadia.AddChild(Dobreta);

Dobreta.AddChild(Mehadia);

Dobreta.AddChild(Craiova);

Craiova.AddChild(Dobreta);

Craiova.AddChild(RimnicuVilcea);
Craiova.AddChild(Pitesti);

RimnicuVilcea.AddChild(Craiova);
Pitesti.AddChild(Craiova);

RimnicuVilcea.AddChild(Sibiu);
RimnicuVilcea.AddChild(Pitesti);

Sibiu.AddChild(RimnicuVilcea);
Pitesti.AddChild(RimnicuVilcea);

Sibiu.AddChild(Fagaras);
Sibiu.AddChild(RimnicuVilcea);

Fagaras.AddChild(Sibiu);
RimnicuVilcea.AddChild(Sibiu);

Fagaras.AddChild(Bucharest);

Bucharest.AddChild(Fagaras);

Pitesti.AddChild(Bucharest);
Pitesti.AddChild(Giurgiu);

Bucharest.AddChild(Pitesti);
Giurgiu.AddChild(Pitesti);

Bucharest.AddChild(Urziceni);
Bucharest.AddChild(Giurgiu);

Urziceni.AddChild(Bucharest);
Giurgiu.AddChild(Bucharest);

Urziceni.AddChild(Hirsova);
Urziceni.AddChild(Vaslui);

Hirsova.AddChild(Urziceni);
Vaslui.AddChild(Urziceni);

Hirsova.AddChild(Eforie);

Eforie.AddChild(Hirsova);

Vaslui.AddChild(Iasi);

Iasi.AddChild(Vaslui);

Iasi.AddChild(Neamt);

Neamt.AddChild(Iasi);







AStarSearch<string> aStarSearch = new AStarSearch<string>(HeuristicType.BFS);

stopwatch.Restart();
aStarSearch.TryFind(Arad, "Bucharest", out Node<string>? aStarResult);
stopwatch.Stop();
Console.WriteLine("Time elapsed: " + stopwatch.Elapsed + "\n\n");