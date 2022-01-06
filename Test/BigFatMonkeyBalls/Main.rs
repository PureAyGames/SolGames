use std::env;
use std::process::Command;

// main
fn main(){
    let cmID = String::new("3H6G47Ssiog8m2NhwwcwLt76ehiq4nWep3H7BoZ7GgMT")
    println!("Big Fat Monkey Balls");

    let mut cmd = Command::new("metaboss")
    cmd.arg("snapshot")
    cmd.arg("mints")
    cmd.arg("--candy-machine-id")
    cmd.arg(cmID)
    cmd.arg("--v2")
    cmd.arg("--output")
    cmd.arg("./Data")
    
    //execute
    match cmd.output(){

        Ok(o) =>{
            println("whore")
        }
        
    }
}


//get data
