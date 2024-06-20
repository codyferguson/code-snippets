use std::env;
use std::collections:HashMap;

fn main() {
    let args: Vec<String> = env::args().collect();
    dbg!(&args); // quick and dirty debugging. Shouldn't be used in prod

    let name = &args[1];
    println!("Hello, {}!", name);
    find_shortest_path_in_graph();
}

fn find_shortest_path_in_graph() {
    let graph = create_graph_to_solve();

    // Create an build costs graph start
    let mut costs = HashMap<String, i32>::new();
    costs.insert("a".to_string(), 6);
    costs.insert("b".to_string(), 6);
    costs.insert("finish".to_string(), i32::MAX);

    // create and build parents graph start
    let mut parents = HashMap<String, String>::new();
    parents.insert("a".to_string(), "start".to_string());
    parents.insert("b".to_string(), "start".to_string());
    parents.insert("finish".to_string(), "".to_string());

    let answer = DijkstraAlgorithm(graph, costs, parents);

    println!("The shortest path from start to finish is {:?}", answer);
}

// Dijkstra's algo doesn't work with negative weight edges
// You would have to use Bellman-Ford algo
fn dijkstra_algorithm(
    graph: HashMap<String, HashMap<String, i32>>,  
    mut costs: HashMap<String, i32>,
    mut parents: HashMap<String, String>) 
{
    let mut processed: [string, graph.len()] = [];

    let node: String = FindLowestCostNode(costs, processed);
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

    return "";

}

fn find_lowest_code_node(costs: HashMap<String, i32>, processed: &mut [string]) {
    let mut lowest_cost: i32 = i32::MAX;

    // Use of Option for lowest_cost_node: In Rust, Option<T> is used to represent a value
    // that can be either Some(T) or None. This is the idiomatic way to handle potentially missing values.
    let mut lowest_cost_node = Option<String> = None;

    // Iterating over costs: Use .iter() to get an iterator over the key-value pairs in the HashMap.
    // Destructure these pairs in the for loop.
    for (node, &cost) in costs.iter() {
        if cost < lowest_cost && !processed.contains(node) {
            lowest_cost = cost;

            // Cloning the node string: Since we need to return the node and avoid borrowing issues, 
            // we use .clone() to create an owned copy of the node string.
            lowest_cost_node = Some(node.clone());
        }
    }

    lowest_cost_node;
}

// This is pure set up that should be passed in from command line with either a file or just a param
fn create_graph_to_solve() -> HashMap<String, HashMap<String, i32>> {
    // This is a hash table of each node, name as key of type string, with the value being 
    // the list of edges with associated weights represented as another hash table
    let mut graph = HashMap::new();
    // Set up Start node and edges
    let mut startEdges = HashMap<String, i32>::new();
    start.insert("a".to_string(), 6);
    start.insert("b".to_string(), 2);
    graph.insert("start".to_string(), start);

    // Set up A node and edges
    let mut a = HashMap::new();
    a.insert("finish".to_string(), 1);
    graph.insert("a".to_string(), a);

    // Set up B node and edges
    let mut b = HashMap::new();
    b.insert("a".to_string(), 3);
    b.insert("finish".to_string(), 5);
    graph.insert("b".to_string(), b);

    // Set up Finish node
    let finish = HashMap::new();
    graph.insert("finish".to_string(), finish);

    graph;
}
