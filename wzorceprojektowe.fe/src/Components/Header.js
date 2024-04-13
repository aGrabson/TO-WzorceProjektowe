import React, {useState, useEffect} from "react";
import "../Styles/Header.css";
import { Dropdown } from "react-nested-dropdown";
import "react-nested-dropdown/dist/styles.css";

export default function Header({FetchCode}) {
  const [selectedItem, setSelectedItem] = useState(null)

  useEffect(() => {
    if(selectedItem !== null)
    {
      FetchCode(selectedItem);
    }
  }, [selectedItem]);

  const items = [
    {
      label: "Creational Patterns",
      items: [
        {
          label: "Factory Method",
          onSelect: () => setSelectedItem("Factory Method"),
        },
        {
          label: "Abstract Factory",
          onSelect: () => setSelectedItem("Abstract Factory"),
        },
        {
          label: "Builder",
          onSelect: () => setSelectedItem("Builder"),
        },
        {
          label: "Prototype",
          onSelect: () => setSelectedItem("Prototype"),
        },
        {
          label: "Singleton",
          onSelect: () => setSelectedItem("Singleton"),
        },
      ],
    },
    {
      label: "Structural Patterns",
      items: [
        {
          label: "Adapter",
          onSelect: () => setSelectedItem("Adapter"),
        },
        {
          label: "Bridge",
          onSelect: () => setSelectedItem("Bridge"),
        },
        {
          label: "Composite",
          onSelect: () => setSelectedItem("Composite"),
        },
        {
          label: "Decorator",
          onSelect: () => setSelectedItem("Decorator"),
        },
        {
          label: "Facade",
          onSelect: () => setSelectedItem("Facade"),
        },
        {
          label: "Flyweight",
          onSelect: () => setSelectedItem("Flyweight"),
        },
        {
          label: "Proxy",
          onSelect: () => setSelectedItem("Proxy"),
        },
      ],
    },
  ];

  return (
    <header className="App-header">
      <Dropdown items={items} containerWidth="300px" className="Dropdown-List">
        {({ isOpen, onClick }) => (
          <button type="button" onClick={onClick}>
            {isOpen ? "Hide Patterns " : "Show Patterns"}
          </button>
        )}
      </Dropdown>
      <div className="PatternName">{selectedItem}</div>
    </header>
  );
}
