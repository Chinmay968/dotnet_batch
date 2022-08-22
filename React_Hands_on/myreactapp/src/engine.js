import React, {Component} from "react";

class Engine extends React.Component
{
    constructor(props)
    {
        super(props);
        this.state = {brand : "Tata" , model : "Nexon"};
    }

    render()
    {
        return(
            <div>
                <h1>
                    My Car {this.state.brand} and model {this.state.model}
                </h1>
            </div>
        );
    }
}

export default Engine