use std::env;
use std::collections:HashMap;

fn main() {
    let args: Vec<String> = env::args().collect();
    dbg!(&args); // quick and dirty debugging. Shouldn't be used in prod

    let name = &args[1];
    println!("Hello, {}!", name);
}

fn FindShortestPathInGraph() {
    let graph = CreateGraphToSolve();

    // Create an build costs graph start
    let mut costs = HashMap<String, i32>::new();
    costs.insert("a", 6);
    costs.insert("b", 6);
    costs.insert("finish", i32::MAX);

    // create and build parents graph start
    let mut parents = HashMap<String, String>::new();
    parents.insert("a", "start");
    parents.insert("b", "start");
    parents.insert("finish", "");

    DijkstraAlgorithm(graph, costs, parents);
}

// Dijkstra's algo doesn't work with negative weight edges
// You would have to use Bellman-Ford algo
fn DijkstraAlgorithm(
    graph: HashMap<String, HashMap<String, i32>>,  
    costs: HashMap<String, i32>,
    parents: HashMap<String, String>) 
{
    let mut processed: = [];

    let node: String = FindLowestCostNode(costs);
    // if all nodes processed, this while loop is done
    while node != null {
        let cost: i32 = costs[node];
        let neighors: HashMap<String, i32> = graph[node];

        for n in neighbors.keys() {
            let new_cost = cost + neighbors[n];
            if costs[n] > new_cost {
                cost[n] = new_cost;
                parents[n] = node;
            }
            processed.insert(node);
            node = FindLowestCodeNode(costs);
        }
    }

}

fn FindLowestCodeNode() {

    return "test";
}

fn CreateGraphToSolve() {
    // This is a hash table of each node, name as key of type string, with the value being 
    // the list of edges with associated weights represented as another hash table
    let mut graph = HashMap<String, HashMap<String, i32>>::new();
    // Set up Start node and edges
    let mut startEdges = HashMap<String, i32>::new();
    startEdges.insert("a".to_string, 6);
    startEdges.insert("b".to_string, 2);

    graph.insert("start".to_string(), startEdges)

    // Set up A node and edges
    let mut aEdges = HashMap<String, i32>:new();
    aEdges.insert("finish", 1);

    graph.insert("a", aEdges);

    // Set up B node and edges
    let mut bEdges = HashMap<String, i32>:new();
    bEdges.insert("a", 3);
    bEdges.insert("finish", 5);

    graph.insert("b", bEdges);

    // Set up Finish node
    graph.insert("finish", HashMap<String, i32>:new(););

    return graph;
}
