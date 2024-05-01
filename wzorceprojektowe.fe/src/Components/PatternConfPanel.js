import React, { useEffect, useState } from "react";
import "../Styles/PatternConfPanel.css";

export default function PatternConfPanel({
  fileSelected,
  files,
  setFiles,
  toInterpret,
  setToInterpret,
  dynamicClass,
}) {
  const [splittedInterpret, setSplittedInterpret] = useState(null);

  useEffect(() => {
    if (toInterpret !== null) {
      setSplittedInterpret(toInterpret.split(" "));
    }
  }, [toInterpret]);

  useEffect(() => {
    if (splittedInterpret !== null) {
      const stringWithSpaces = splittedInterpret.join(" ");
      setToInterpret(stringWithSpaces);
    }
  }, [splittedInterpret]);

  const HandleChange = (value, index, hashName) => {
    setSplittedInterpret((prev) => {
      const updatedArray = [...prev];
      updatedArray[index] = hashName + value + "#";
      return updatedArray;
    });
  };

  const AddField = (key) => {
    const regex = /#F(\d+);/g;
    let highestNumber = 0;
    let match;
    while ((match = regex.exec(toInterpret)) !== null) {
      const number = parseInt(match[1]);
      if (number > highestNumber) {
        highestNumber = number;
      }
    }
    const newKeyNumber = highestNumber + 1;
    const newKey = `#F${newKeyNumber}`;
    toInterpret += `${newKey};${key};int#Nazwa# `;
    setToInterpret(toInterpret);
  };
  
  const EraseField = (key) => {
    const regex = new RegExp(`#${key}#[^#]*# `, "g");
    const updatedToInterpret = toInterpret.replace(regex, "");
    setToInterpret(updatedToInterpret);
  };
  const AddMethod = () => {};
  const AddClass = () => {
    const regex = /#C(\d+)#/g;
    let highestNumber = 0;
    let match;
    while ((match = regex.exec(toInterpret)) !== null) {
      const number = parseInt(match[1]);
      if (number > highestNumber) {
        highestNumber = number;
      }
    }
    const newKeyNumber = highestNumber + 1;
    const newKey = `#C${newKeyNumber}#`;
    const replacedStr = dynamicClass.replaceAll("#C#", newKey);
    const newClass = { fileName: newKey, content: replacedStr };

    toInterpret += `${newKey}newClass# `;
    files.push(newClass);

    setFiles(files);
    setToInterpret(toInterpret);
  };

  const EraseClass = (key) => {
    const index = files.findIndex((file) => file.fileName === "#" + key + "#");
    if (index !== -1) {
      files.splice(index, 1);
      setFiles([...files]);
    }
    const regex = new RegExp(`#${key}#[^#]*# `, "g");
    const updatedToInterpret = toInterpret.replace(regex, "");
    setToInterpret(updatedToInterpret);
  };

  return files !== null ? (
    <div className="patternConfPanel">
      <div className="confItems">
        {splittedInterpret !== null
          ? splittedInterpret.map((item, index) => {
              const hashSplitted = item.split("#");
              if(hashSplitted.length === 1) return null;
              const semiColonSplitted = hashSplitted[1].split(";");
              if (semiColonSplitted.length !== 1) return null;
              return (
                <div style={{ gap: 4 }}>
                  <div
                    style={{
                      flexDirection: "row",
                      display: "flex",
                      alignItems: "center",
                      gap: 4,
                    }}
                  >
                    <div className="form__group field" key={index}>
                      <input
                        type="input"
                        value={hashSplitted[2]}
                        onChange={(e) =>
                          HandleChange(
                            e.target.value,
                            index,
                            "#" + hashSplitted[1] + "#"
                          )
                        }
                        className="form__field"
                        placeholder="Add Interface"
                        name="add Interface"
                        id="add Interface"
                        required
                      />
                      <label htmlFor="add Interface" className="form__label">
                        {hashSplitted[1]}
                      </label>
                    </div>
                    <button
                      style={{
                        borderRadius: 27,
                        borderWidth: 2,
                        width: 30,
                        height: 30,
                        backgroundColor: "blue",
                        display: "flex",
                        justifyContent: "center",
                        alignItems: "center",
                        color: "white",
                        fontSize: 18,
                        fontWeight: "bold",
                      }}
                      onClick={() => AddField(hashSplitted[1])}
                    >
                      F
                    </button>
                    <button
                      style={{
                        borderRadius: 27,
                        borderWidth: 2,
                        width: 30,
                        height: 30,
                        backgroundColor: "green",
                        display: "flex",
                        justifyContent: "center",
                        alignItems: "center",
                        color: "white",
                        fontSize: 18,
                        fontWeight: "bold",
                      }}
                      onClick={AddMethod}
                    >
                      M
                    </button>
                    <button
                      style={{
                        borderRadius: 27,
                        borderWidth: 2,
                        width: 30,
                        height: 30,
                        backgroundColor: "red",
                        display: "flex",
                        justifyContent: "center",
                        alignItems: "center",
                        color: "white",
                        fontSize: 18,
                        fontWeight: "bold",
                      }}
                      onClick={() => EraseClass(hashSplitted[1])}
                    >
                      -
                    </button>
                  </div>
                  {splittedInterpret.map((item2, index2) => {
                    const hashSplitted2 = item2.split("#");
                    if(hashSplitted2.length === 1) return null;
                    const semiColonSplitted2 = hashSplitted2[1].split(";");
                    if (semiColonSplitted2.length === 1) return null;
                    if (semiColonSplitted2[1] !== hashSplitted[1]) return null;
                    return (
                      <div
                        style={{
                          flexDirection: "row",
                          display: "flex",
                          alignItems: "center",
                          gap: 4,
                          marginLeft:46,
                        }}
                      >
                        <div className="form__group field" key={index2}>
                          <input
                            type="input"
                            value={hashSplitted2[2]}
                            onChange={(e) =>
                              HandleChange(
                                e.target.value,
                                index2,
                                "#" + hashSplitted2[1] + "#"
                              )
                            }
                            className="form__field"
                            placeholder="Add Interface"
                            name="add Interface"
                            id="add Interface"
                            required
                          />
                          <label
                            htmlFor="add Interface"
                            className="form__label"
                          >
                            {hashSplitted2[1]}
                          </label>
                        </div>
                        <button
                          style={{
                            borderRadius: 27,
                            borderWidth: 2,
                            width: 30,
                            height: 30,
                            backgroundColor: "red",
                            display: "flex",
                            justifyContent: "center",
                            alignItems: "center",
                            color: "white",
                            fontSize: 18,
                            fontWeight: "bold",
                          }}
                          onClick={() => EraseField(hashSplitted2[1])}
                        >
                          -
                        </button>
                      </div>
                    );
                  })}
                </div>
              );
            })
          : null}
        <button
          style={{
            borderRadius: 27,
            borderWidth: 2,
            backgroundColor: "brown",
            display: "flex",
            justifyContent: "center",
            alignItems: "center",
            color: "white",
            fontSize: 18,
            fontWeight: "bold",
          }}
          onClick={AddClass}
        >
          Add class
        </button>
      </div>
    </div>
  ) : null;
}
