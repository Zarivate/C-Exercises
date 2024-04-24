import React from "react";
import logo from "./logo.svg";
import "./App.css";
import Card from "./Components/Card/Card";
import CardList from "./Components/Card/CardList/CardList";
import Search from "./Components/Search/Search";

function App() {
  return (
    <div className="App">
      <Search />
      <Search />
      <CardList />
    </div>
  );
}

export default App;
