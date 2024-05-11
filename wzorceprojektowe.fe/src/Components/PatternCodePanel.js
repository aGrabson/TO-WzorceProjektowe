import React, { useState, useEffect } from "react";
import "../Styles/PatternCodePanel.css";
import { Prism as SyntaxHighlighter } from "react-syntax-highlighter";
import { darcula } from "react-syntax-highlighter/dist/esm/styles/prism";

export default function PatternCodePanel({ patternData, toInterpret }) {
  const [code, setCode] = useState(null);

  useEffect(() => {
    if (toInterpret !== null) {
      const splittedInterpret = toInterpret.split(" ");
      let replacedStr = patternData;
      splittedInterpret.map((item, index) => {
        const hashSplitted = item.split("#");
        const regex = new RegExp(`#F\\d+;${hashSplitted[1]}.*`);
        const test = splittedInterpret.filter((x) => regex.test(x));
        let fieldText = "";
        test.forEach((fieldItem) => {
          const fieldHashSplitted = fieldItem.split("#");
          const tmp = fieldHashSplitted[1].split(";");
          fieldText += `public ${tmp[2]} ${fieldHashSplitted[2]};\n\t`;
        });

        const regexMethod = new RegExp(`#M\\d+;${hashSplitted[1]}.*`);
        const testMethod = splittedInterpret.filter((x) => regexMethod.test(x));
        let methodText = "";
        testMethod.forEach((methodItem) => {
          const methodHashSplitted = methodItem.split("#");
          const tmp = methodHashSplitted[1].split(";");
          const parametersTmp = tmp[3].split(".").filter(Boolean);
          const parameters = parametersTmp.join(" ");
          methodText += `public ${tmp[2]} ${methodHashSplitted[2]}(${parameters.slice(0, -1)}){}\n\t`;
        });

        replacedStr = replacedStr.replaceAll(
          `#F;#${hashSplitted[1]}#`,
          fieldText
        );
        replacedStr = replacedStr.replaceAll(
          `#M;#${hashSplitted[1]}#`,
          methodText
        );
        replacedStr = replacedStr.replaceAll(
          "#" + hashSplitted[1] + "#",
          hashSplitted[2]
        );
      });
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
      ) : null}
    </div>
  );
}
