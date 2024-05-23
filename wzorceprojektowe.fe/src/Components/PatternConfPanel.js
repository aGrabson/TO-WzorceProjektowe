import React, { useEffect, useState } from "react";
import "../Styles/PatternConfPanel.css";
import SelectFromList from "./SelectFromList";

export default function PatternConfPanel({
  fileSelected,
  files,
  setFiles,
  toInterpret,
  setToInterpret,
  dynamicClass,
}) {
  const [splittedInterpret, setSplittedInterpret] = useState(null);

  const regexForMinus = /^(AC|CC|I)/;

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
  const AddParameter = (index, key, methodName) => {
    const name = key.split(";");
    setSplittedInterpret((prev) => {
      const updatedArray = [...prev];
      updatedArray[index] =
        "#" +
        name[0] +
        ";" +
        name[1] +
        ";" +
        name[2] +
        ";" +
        name[3] +
        "int.s,#" +
        methodName +
        "#";
      return updatedArray;
    });
  };
  const EraseField = (key) => {
    const regex = new RegExp(`#${key}#[^#]*# `, "g");
    const updatedToInterpret = toInterpret.replace(regex, "");
    setToInterpret(updatedToInterpret);
  };
  const AddMethod = (key) => {
    const regex = /#M(\d+);/g;
    let highestNumber = 0;
    let match;
    while ((match = regex.exec(toInterpret)) !== null) {
      const number = parseInt(match[1]);
      if (number > highestNumber) {
        highestNumber = number;
      }
    }
    const newKeyNumber = highestNumber + 1;
    const newKey = `#M${newKeyNumber}`;
    toInterpret += `${newKey};${key};int;#Nazwa# `;
    setToInterpret(toInterpret);
  };
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

  const handleCustomInputChange = (index, customValue, hashName, name) => {
    var regex = /^F\d/;
    const splittedHashName = hashName.split(";");
    if (regex.test(splittedHashName[0])) {
      setSplittedInterpret((prev) => {
        const updatedArray = [...prev];
        updatedArray[index] =
          "#" +
          splittedHashName[0] +
          ";" +
          splittedHashName[1] +
          ";" +
          customValue +
          "#" +
          name +
          "#";
        return updatedArray;
      });
    } else {
      setSplittedInterpret((prev) => {
        const updatedArray = [...prev];
        updatedArray[index] =
          "#" +
          splittedHashName[0] +
          ";" +
          splittedHashName[1] +
          ";" +
          customValue +
          ";" + splittedHashName[3] + "#" +
          name +
          "#";
        return updatedArray;
      });
    }
  };

  const handleCustomParameterChange = (
    index,
    customValue,
    hashName,
    name,
    methodIndex
  ) => {
    const splittedHashName = hashName.split(";");
    const splittedParameters = splittedHashName[3].split(",").filter(Boolean);

    const parts = splittedParameters[index].split(".");

    parts[0] = customValue;

    splittedParameters[index] = parts.join(".");

    splittedHashName[3] = splittedParameters.join(",");

    setSplittedInterpret((prev) => {
      const updatedArray = [...prev];
      updatedArray[methodIndex] =
        "#" +
        splittedHashName[0] +
        ";" +
        splittedHashName[1] +
        ";" +
        splittedHashName[2] +
        ";" +
        splittedHashName[3] +
        ",#" +
        name +
        "#";
      return updatedArray;
    });
  };

  const HandleParameterChange = (value, index, hashName, methodIndex, name) => {
    const splittedHashName = hashName.split(";");
    const splittedParameters = splittedHashName[3].split(",").filter(Boolean);
    const parts = splittedParameters[index].split(".");
    parts[1] = value;
    splittedParameters[index] = parts.join(".");

    splittedHashName[3] = splittedParameters.join(",");

    setSplittedInterpret((prev) => {
      const updatedArray = [...prev];
      updatedArray[methodIndex] =
        "#" +
        splittedHashName[0] +
        ";" +
        splittedHashName[1] +
        ";" +
        splittedHashName[2] +
        ";" +
        splittedHashName[3] +
        ",#" +
        name +
        "#";
      return updatedArray;
    });
  };

  const EraseParameter = (index, hashName, methodIndex, name) => {
    const splittedHashName = hashName.split(";");
    const splittedParameters = splittedHashName[3].split(",").filter(Boolean);

    splittedParameters.splice(index, 1);
    splittedHashName[3] = splittedParameters.join(",");
    const splitter =  splittedParameters.length === 0 ? "#" : ",#"

    setSplittedInterpret((prev) => {
      const updatedArray = [...prev];
      updatedArray[methodIndex] =
        "#" +
        splittedHashName[0] +
        ";" +
        splittedHashName[1] +
        ";" +
        splittedHashName[2] +
        ";" +
        splittedHashName[3] +
        splitter +
        name +
        "#";
      return updatedArray;
    });
  };

  const renderParameters = (semiColonSplitted2, hashSplitted2, methodIndex) => {
    return semiColonSplitted2.length === 4
      ? (() => {
          const commaSplitted = semiColonSplitted2[3]
            .split(",")
            .filter(Boolean);
          return commaSplitted.map((item, index) => {
            const [type, name] = item.split(".");

            return (
              <div
                className="form__group field"
                key={index}
                style={{ flexDirection: "row", marginLeft: 92 }}
              >
                <input
                  type="input"
                  value={name}
                  onChange={(e) =>
                    HandleParameterChange(
                      e.target.value,
                      index,
                      hashSplitted2[1],
                      methodIndex,
                      hashSplitted2[2]
                    )
                  }
                  className="form__field"
                  placeholder="Add Interface"
                  name="add Interface"
                  id="add Interface"
                  required
                />
                <label htmlFor="add Interface" className="form__label">
                  {"Parameter" + index}
                </label>

                <SelectFromList
                  handleCustomInputChange={handleCustomParameterChange}
                  index={index}
                  hashName={hashSplitted2[1]}
                  name={hashSplitted2[2]}
                  methodIndex={methodIndex}
                />
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
                  onClick={() =>
                    EraseParameter(
                      index,
                      hashSplitted2[1],
                      methodIndex,
                      hashSplitted2[2]
                    )
                  }
                >
                  -
                </button>
              </div>
            );
          });
        })()
      : null;
  };

  return files !== null ? (
    <div className="patternConfPanel">
      <div className="confItems">
        {splittedInterpret !== null
          ? splittedInterpret.map((item, index) => {
              const hashSplitted = item.split("#");
              if (hashSplitted.length === 1) return null;
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
                      onClick={() => AddMethod(hashSplitted[1])}
                    >
                      M
                    </button>
                    {regexForMinus.test(hashSplitted[1]) ? null : (
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
                    )}
                  </div>
                  {splittedInterpret.map((item2, index2) => {
                    const hashSplitted2 = item2.split("#");
                    if (hashSplitted2.length === 1) return null;
                    const semiColonSplitted2 = hashSplitted2[1].split(";");
                    if (semiColonSplitted2.length === 1) return null;
                    if (semiColonSplitted2[1] !== hashSplitted[1]) return null;

                    return (
                      <div>
                        <div
                          style={{
                            flexDirection: "row",
                            display: "flex",
                            alignItems: "center",
                            gap: 4,
                            marginLeft: 46,
                          }}
                        >
                          <div
                            className="form__group field"
                            key={index2}
                            style={{ flexDirection: "row" }}
                          >
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
                            <SelectFromList
                              handleCustomInputChange={handleCustomInputChange}
                              index={index2}
                              hashName={hashSplitted2[1]}
                              name={hashSplitted2[2]}
                            />
                          </div>

                          {semiColonSplitted2.length === 4 ? (
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
                              onClick={() =>
                                AddParameter(
                                  index2,
                                  hashSplitted2[1],
                                  hashSplitted2[2]
                                )
                              }
                            >
                              P
                            </button>
                          ) : null}
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

                        {renderParameters(
                          semiColonSplitted2,
                          hashSplitted2,
                          index2
                        )}
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
