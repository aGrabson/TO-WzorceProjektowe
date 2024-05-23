import React, { useState, useEffect } from "react";
import "../Styles/Header.css";
import { Dropdown } from "react-nested-dropdown";
import "react-nested-dropdown/dist/styles.css";
import { DownloadCode } from "../Controllers/PatternController";

export default function Header({ FetchCode, toInterpret }) {
  const [selectedItem, setSelectedItem] = useState(null);
  const [selectedLanguage, setSelectedLanguage] = useState(null);

  useEffect(() => {
    if (selectedItem !== null) {
      FetchCode(selectedItem);
    }
  }, [selectedItem]);

  const downloadFile = async () => {
    if (!selectedItem) {
      alert("Please select a pattern first.");
      return;
    }

    if (!selectedLanguage) {
      alert("Please select a language (Java or C#).");
      return;
    }

    await DownloadCode({
      selectedItem: selectedItem,
      toInterpret: toInterpret,
      languageCode: selectedLanguage,
    });
  };

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
    {
      label: "Behavioral Patterns",
      items: [
        {
          label: "Chain of Responsibility",
          onSelect: () => setSelectedItem("Chain of Responsibility"),
        },
        {
          label: "Command",
          onSelect: () => setSelectedItem("Command"),
        },
        {
          label: "Iterator",
          onSelect: () => setSelectedItem("Iterator"),
        },
        {
          label: "Mediator",
          onSelect: () => setSelectedItem("Mediator"),
        },
        {
          label: "Memento",
          onSelect: () => setSelectedItem("Memento"),
        },
        {
          label: "Observer",
          onSelect: () => setSelectedItem("Observer"),
        },
        {
          label: "State",
          onSelect: () => setSelectedItem("State"),
        },
        {
          label: "Strategy",
          onSelect: () => setSelectedItem("Strategy"),
        },
        {
          label: "Template Method",
          onSelect: () => setSelectedItem("Template Method"),
        },
        {
          label: "Visitor",
          onSelect: () => setSelectedItem("Visitor"),
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
      {selectedItem ? (
        <div
          style={{
            flexDirection: "row",
            display: "flex",
            alignItems: "center",
            color: "white",
          }}
        >
          <div>
            <label>
              <input
                type="radio"
                value="Java"
                checked={selectedLanguage === "Java"}
                onChange={() => setSelectedLanguage("Java")}
              />
              Java
            </label>
            <label>
              <input
                type="radio"
                value="C#"
                checked={selectedLanguage === "C#"}
                onChange={() => setSelectedLanguage("C#")}
              />
              C#
            </label>
          </div>
          <button onClick={downloadFile}>Download .zip</button>
          <div className="PatternName">{selectedItem}</div>
        </div>
      ) : null}
    </header>
  );
}
