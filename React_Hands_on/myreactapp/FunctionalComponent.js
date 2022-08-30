import './App.css';

function App(){
    return(
        <div>
            < AppChild name = "Matt" />
        </div>
    );
}
function AppChild(props){
    return(
        <h1>
            My name is {props.name} 
        </h1>
    );
}

export default App;