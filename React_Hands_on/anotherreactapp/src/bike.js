import React,{Component} from 'react' ;

class Bike extends React.Component
{
    constructor(props)
    {
        super(props);
        this.state = {brand :"Yamaha",bikename :"Yamaha MT-15",model :"MT-15"};
        
    }

    render()
    {
        return(
            <div>
                <h1>
                    My Bike is {this.state.bikename}
                </h1>
            </div>
        );
    }
}

export default Bike