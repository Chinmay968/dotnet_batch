import './App.css';

function FunctionalSchool(){
    return(
        <div>
            < SchoolChild name = "RAIT" location = "Nerul" />
        </div>
    );
}
function SchoolChild(props){
    return(
        <h1>
            My College name is {props.name} and is located in {props.location}
        </h1>
    );
}

export default FunctionalSchool;