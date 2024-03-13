import React from 'react';
import './App.css';
// Make the necessary imports for the Header and the BowlerList
import Header from './Header';
import BowlerList from './Bowlers/BolwerList';

function App() {
  // return the Header and BowlerList in the App div
  return (
    <div className="App">
      <Header title="Welcome to Big League Bowling" />
      <br />
      <BowlerList />
    </div>
  );
}

export default App;
