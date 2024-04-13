import React, { useEffect, useState } from "react";
import "../Styles/PatternConfPanel.css";

export default function PatternConfPanel({
  fileSelected,
  files,
  setFiles,
  toInterpret,
  setToInterpret,
}) {
  const [splittedInterpret, setSplittedInterpret] = useState(null);

  useEffect(() => {
    if (toInterpret !== null) {
      setSplittedInterpret(toInterpret.split(" "));
    }
    console.log(toInterpret);
  }, []);

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

  return files !== null ? (
    <div className="patternConfPanel">
      <div className="confItems">
        {splittedInterpret !== null
          ? splittedInterpret.map((item, index) => {
              const hashSplitted = item.split("#");
              return (
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
              );
            })
          : null}
      </div>
    </div>
  ) : null;
}
