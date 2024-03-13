// Make a typescript file for the Bowler data we will fetch from the ASP.NET API
export type Bowler = {
  bowlerId: number;
  bowlerFirstName: string;
  bowlerMiddleInit: string;
  bowlerLastName: string;
  bowlerAddress: string;
  bowlerCity: string;
  bowlerState: string;
  bowlerZip: string;
  bowlerPhoneNumber: string;

  // Bring in team as any because it will be a dictionary
  team: any;
};
