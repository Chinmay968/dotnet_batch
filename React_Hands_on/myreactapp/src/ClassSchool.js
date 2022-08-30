import React from "react";

class ClassSchool extends React.Component{
    constructor(props){
        super(props);

        this.state = {name:"K.C Gandhi" , location:"Kalyan"};
    
    }
    render(){
        return(
            
            <div>
                <h2>
                    My School name is {this.state.name} and is located in {this.state.location}
                </h2>
            </div>    
        );
    }

}

export default ClassSchool;