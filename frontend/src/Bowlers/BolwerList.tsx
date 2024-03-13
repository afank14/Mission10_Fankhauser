// Make all the necessary imports
import { useEffect, useState } from 'react';
import { Bowler } from '../types/Bowler';

function BowlerList() {
  // useState to make a bowlerData variable
  const [bowlerData, setBowlerData] = useState<Bowler[]>([]);

  // useEffect here so it doesn't fetch like crazy
  useEffect(() => {
    // Make a variable that holds an async function that fetches from the bowling API in ASP.NET
    const fetchBowlerData = async () => {
      const rsp = await fetch('http://localhost:5122/bowling');
      const b = await rsp.json();
      setBowlerData(b);
    };
    // Call the said function to set the bowler data
    fetchBowlerData();
  }, []);

  // Make the return statement with a header and the table
  return (
    <>
      <div className="row">
        <h4 className="text-center">Marlins and Sharks Bowlers</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>First Name</th>
            <th>Middle Initial</th>
            <th>Last Name</th>
            <th>Team Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip Code</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {/* Map the bowler data to the table */}
          {bowlerData.map((b) => (
            <tr key={b.bowlerId}>
              <td>{b.bowlerFirstName}</td>
              <td>{b.bowlerMiddleInit}</td>
              <td>{b.bowlerLastName}</td>
              <td>{b.team.teamName}</td>
              <td>{b.bowlerAddress}</td>
              <td>{b.bowlerCity}</td>
              <td>{b.bowlerState}</td>
              <td>{b.bowlerZip}</td>
              <td>{b.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

// Export the BowlerList for import in the App.tsx file
export default BowlerList;
