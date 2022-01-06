    using System;
    using System.Diagnostics;

namespace MonkeyNutz{

class Program{

    public static string candyMachineID = "3H6G47Ssiog8m2NhwwcwLt76ehiq4nWep3H7BoZ7GgMT";
    public static bool v2 = true;
    public static string DataDir = "./Data/";
    static void Main(string[] args){

        Console.WriteLine("HOLY FUCK look at that monkeys balls");

        string getMintAccCmd = GetMintAcounts(candyMachineID, DataDir, v2);
        //Process.Start("cmd.exe", "/K " + getMintAccCmd);
        ExecuteCommand(getMintAccCmd);
        
    }



    // get the mint acounts of all minted nfts.
    //mint acounts are the solana accounts of nfts NOT the person who minted the nft
    // they just hold the metadata and stuff
    public static string GetMintAcounts(string cmID, string outputDir, bool v2){
        if(v2){
            
            return "metaboss snapshot mints --candy-machine-id " + cmID + " --v2" + " --output " + outputDir;
        }
        else{
            return "metaboss snapshot mints --candy-machine-id " + cmID + " --output " + outputDir;
        }
    }

        public static void ExecuteCommand(string command)
        {
            Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "/bin/bash";
            proc.StartInfo.Arguments = "-c \" " + command + " \"";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start();

            while (!proc.StandardOutput.EndOfStream)
            {
                Console.WriteLine(proc.StandardOutput.ReadLine());
            }
        }
    
    
}


}