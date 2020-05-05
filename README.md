# BFS Algorithm C#

### Node API :
   #### Create Node : 
 
 ```Node<T> node = new Node<T>()``` 
 where T refers to the data (string,Object or other template). 
 
 
### Graph API : 
#### Create Graph : 
 
 ```Graph<T> graph = new Graph<T>()``` 
 where T refers to the data (string,Object or other template).
  
#### Add Node to the Graph:
 
 ```graph.addElement(Node<T>)```
 
 for Example ```graph.addElement(new Node<string>(0, "0"))``` (the T represent string class)
 
#### Add Graph Edge :
 
 before adding Graph edge you will need to add them to the Graph Object with the  addElement function
   
 ```graph.addEdge(int source,int destination)``` the source and destination is the Nodes id.
 
#### Run BFS Algorithm :
 
 ```graph.hasPathBFS(int source,int destination)``` where source and destination is the Nodes id.
 
## Run Example
<img width="850" alt="Screen Shot 2020-05-06 at 1 58 20" src="https://user-images.githubusercontent.com/44754325/81124019-15382700-8f3d-11ea-93a9-1f9fc715db78.png">

## Output
```

Start
True
True
True
End
```
 
