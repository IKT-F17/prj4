//using System.Collections.Generic;
//using MonstersMapsTowers.Interfaces;


/////<Summary>
/////
///// Takes:
///// Returns: Stack<nodes>
/////
///// </Summary>


//namespace MonstersMapsTowers.Class.Pathing
//{
//    /// <summary>
//    /// Pathfinder class is supposed to take a "raw path" consisting of a set of coordinates and attributes to denote walkable tiles.
//    /// it should then use an A* algorithm to find the "cheapest" Path from the start to the player base. the "path" would then be returned as a stack.
//    ///
//    /// Pathfinder is NOT implemented at this time due to time constraints. 
//    /// </summary>


//    public class Node
//    {
//        public Node(string direction)
//        {
//        }
//        //public string node { get; set; }
//    }

//    public class Pathfinder : IPathfinder
//    {
//        Stack<string> path = new Stack<string>();

//        public Stack<string> CalculatePath(object rawPath)
//        {
//            Stack<string> path = new Stack<string>();
//            /// TODO: Converting the raw path to nodes by sending it through an algorithem (A*) 

//            return path;
//        }

//        private Stack<Node> nodes;

//        void AddNodeToStack(string direction)
//        {
//            var node = new Node(direction);
//            nodes.Push(node);
//        }
//    }
//}






////namespace Utilities.Pathing
////{
////    public class Pathfinder
////    {
////        private Node[] nodes;
////        private int w;

////        public Pathfinder(int mapWidth, INodeUpdate[] walkableNodes?)//??
////        {
////            this.w = mapWidth;
////            this.nodes = new Array<Node>(this.w * *2);
////            for (int i = 0; i < this.w * *2; i++)//let i??
////            {
////                var pos = this.getPosition(i);
////                this.nodes[i] = new Node(pos.x, pos.y);
////            }
////            if (walkableNodes)
////            { this.updateWalkableNodes(walkableNodes); }
////        }

////        /**
////         * Finds a path from the `start` to the `end` and returns a list of points in between.
////         * @param start The start point.
////         * @param end The end point.
////         */
////        public async<IPoint[]> findPath(IPoint start, IPoint end)//dont get it
////        {
////            return new async(resolve: (IPoint[] path) => void, reject: (err: Error) => void) => 
////            {
////                Node startNode = this.nodes[this.getIndex(start.x, start.y)];
////                Node endNode = this.nodes[this.getIndex(end.x, end.y)];

////                var openSet = new Heap<Node>(this.nodes.length);
////                var closedSet = new HashSet<Node>();

////                openSet.add(startNode);

////                while (openSet.count > 0)
////                {
////                    var currentNode = openSet.removeFirst();
////                    closedSet.add(currentNode);

////                    if (currentNode.x == end.x && currentNode.y == end.y)
////                    {
////                        openSet = null;
////                        closedSet = null;
////                        resolve(this.retracePath(startNode, endNode));
////                        return;
////                    }

////                    var neighbors = this.getNeighbors(currentNode);
////                    for (const neighbor of neighbors) {
////                        if (!neighbor.walkable || closedSet.contains(neighbor))
////                        {
////                            continue;
////                        }
////                        var moveCost = currentNode.gCost + this.getDistance(currentNode, neighbor);
////                        if (moveCost < neighbor.gCost || !openSet.contains(neighbor))
////                        {
////                            neighbor.gCost = moveCost;
////                            neighbor.hCost = this.getDistance(neighbor, endNode);
////                            neighbor.parent = currentNode;

////                            if (!openSet.contains(neighbor))
////                            {
////                                openSet.add(neighbor);
////                            }
////                        }
////                    }
////                }
////                reject(new Error('No path found.'));
////                return;
////            }
////        }

////        /**
////         * Applies updates to the nodes known by this pathfinder.
////         * @param updates The node updates to apply.
////         */
////        public void updateWalkableNodes(INodeUpdate[] updates)
////        {
////            for (var update of updates)
////            {
////                this.nodes[this.getIndex(update.x, update.y)].walkable = update.walkable;
////            }
////            updates = null;
////        }

////        /**
////         * Releases any resources held by this pathfinder.
////         */
////        public void destroy()
////        {
////            this.nodes = null;
////        }

////        //        private IPoint[] simplifyPath(Node[] path)
////        //        {
////        //            if (path.length < 2)
////        //            {
////        //                if (path.length == 0)
////        //                {
////        //                    return [];
////        //                }
////        //                return path.map(p) =>
////        //                {
////        //                    return x: p.x,  y: p.y;
////        //                }
////        //            }
////        //            const IPoint[] waypoints = [];//const waypoints: Point[] = [];
////        //            let IPoint lastDirection = //let lastDirection: IPoint =??
////        //            {
////        //                int x = 0;
////        //                int y = 0;
////        //            }

////        //            for (let i = 1; i < path.length; i++)
////        //            {
////        //                const direction: IPoint =
////        //                {
////        //                    x:
////        //                    path[i - 1].x - path[i].x;
////        //                    y:
////        //                    path[i - 1].y - path[i].y;
////        //                }
////        //                if (direction.x != = lastDirection.x || direction.y != = lastDirection.y)
////        //                {
////        //                    // tslint:disable no-bitwise
////        //                    if ((direction.x & direction.y) !== 0)
////        //                    {
////        //                        // tslint:enable no-bitwise
////        //                        if (direction.x != = lastDirection.x)
////        //                        {
////        //                            waypoints.push(
////        //                                    x:
////        //                                    path[i - 1].x,
////        //                                    y:
////        //                                    path[i].y;
////        //                                )
////        //                        }
////        //                        else if (direction.y != = lastDirection.y)
////        //                        {
////        //                            waypoints.push(
////        //                                x: path[i].x,
////        //                                y: path[i - 1].y);
////        //                        }


////        //                        else
////        //                        {
////        //                            waypoints.push
////        //                                (
////        //                                    x: path[i].x,
////        //                                    y: path[i].y;
////        //                                )
////        //                        }
////        //                    }
////        //                }

////        //                lastDirection = direction;
////        //    }
////        //waypoints.push(
////        //      x: path[path.length - 1].x,
////        //      y: path[path.length - 1].y
////        //    );
////        //    return waypoints;
////        //  }
////        private IPoint[] retracePath(Node start, Node end)
////        {
////            const Node[] path = [];
////            Node currentNode = end;
////            while (currentNode !== start)
////            {
////                path.push(currentNode);
////                currentNode = currentNode.parent;
////            }
////            var points = this.simplifyPath(path.reverse());
////            return points;
////        }

////        private int getIndex(int x, int y)
////        {
////            return y * this.w + x;
////        }

////        private int getPosition(int index) //: { x: number, y: number }
////        {
////            var x = index % this.w;
////            var y = (index - x) / this.w;
////            return { x, y };
////        }

////        private Node[] getNeighbors(Node node)
////        {
////            const Node[] neighbors = [];
////            for (int x = -1; x <= 1; x++)
////            {
////                for (int y = -1; y <= 1; y++)
////                {
////                    // self
////                    if (x == 0 && y == 0)
////                    {
////                        continue;
////                    }

////                    var relX = node.x + x;
////                    var relY = node.y + y;

////                    if (relX >= 0 && relX < this.w && relY >= 0 && relY < this.w)
////                    {
////                        neighbors.push(this.nodes[this.getIndex(relX, relY)]);
////                    }
////                }
////            }
////            return neighbors;
////        }

////        private int getDistance(Node nodeA, Node nodeB)
////        {
////            var distX = Math.Abs(nodeA.x - nodeB.x);
////            var distY = Math.Abs(nodeA.y - nodeB.y);

////            if (distX > distY)
////            {
////                return 14 * distY + 10 * (distX - distY);
////            }
////            return 14 * distX + 10 * (distY - distX);
////        }
////    }

////}

