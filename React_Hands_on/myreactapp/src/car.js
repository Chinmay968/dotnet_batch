import React,{Component} from 'react' ;

class Car extends React.Component
{
    constructor(props)
    {
        super(props);
        this.state = {brand : "Ford" , make : "Ford" , carbrandname : "Ford" , carname : "Mustang" , model : "Ford" , brand : "Tata"};
        
    }

    render()
    {
        return(
            <div>
                <h1>
                    My Car is {this.state.carname}
                </h1>
            </div>
        );
    }
}

export default Car