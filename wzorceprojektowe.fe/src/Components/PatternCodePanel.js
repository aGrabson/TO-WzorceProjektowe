import React, { useState, useEffect } from "react";
import "../Styles/PatternCodePanel.css";
import { Prism as SyntaxHighlighter } from "react-syntax-highlighter";
import { darcula } from "react-syntax-highlighter/dist/esm/styles/prism";

export default function PatternCodePanel({ patternData, toInterpret }) {
  const [code, setCode] = useState(null);

  useEffect(() => {
    if(toInterpret !== null)
    {
      const splittedInterpret = toInterpret.split(" ");
      let replacedStr = patternData;
      splittedInterpret.map((item, index) => {
        const hashSplitted = item.split("#");
        replacedStr = replacedStr.replaceAll("#" + hashSplitted[1] + "#", hashSplitted[2])
      })
      setCode(replacedStr);
    }

  }, [toInterpret, patternData]);

  return (
    <div className="patternCodePanel">
      {code !== null ? (
        <div>
          <SyntaxHighlighter language="csharp" style={darcula}>
            {code}
          </SyntaxHighlighter>
        </div>
      ) : (
        null
      )}
    </div>
  );
}
