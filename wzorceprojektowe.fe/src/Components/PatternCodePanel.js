import React, { useState, useEffect } from "react";
import "../Styles/PatternCodePanel.css";
import { Prism as SyntaxHighlighter } from "react-syntax-highlighter";
import { darcula } from "react-syntax-highlighter/dist/esm/styles/prism";

export default function PatternCodePanel({ patternData, toInterpret, dynamicMethodI, dynamicMethodC, dynamicMethodAC }) {
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
          const methodHashSplitted = methodItem.split("#").filter(Boolean);
          const methodSemicolonSplitted = methodHashSplitted[0].split(";");
          const methodParametersColonSplitted = methodSemicolonSplitted[3].split(",").filter(Boolean);
          let parametersWithoutType = "";
          methodParametersColonSplitted.forEach((parameterItem)=>{
            const tmpParameter = parameterItem.split(".").filter(Boolean);
            parametersWithoutType += tmpParameter[1] +",";
          })
          const parametersTmp = methodSemicolonSplitted[3].split(".").filter(Boolean);
          const parameters = parametersTmp.join(" ");
          if(/^I.*/.test(methodSemicolonSplitted[1])){
            let methodI = dynamicMethodI.replaceAll("#TYPE#", methodSemicolonSplitted[2]);
            methodI = methodI.replaceAll("#NAME#", methodHashSplitted[1]);
            methodI = methodI.replaceAll("#PARAMS#", parameters.slice(0, -1));
            methodText += methodI;
          }else if(/^AC.*/.test(methodSemicolonSplitted[1])){
            let methodAC = dynamicMethodAC.replaceAll("#TYPE#", methodSemicolonSplitted[2]);
            methodAC = methodAC.replaceAll("#NAME#", methodHashSplitted[1]);
            methodAC = methodAC.replaceAll("#PARAMS#", parameters.slice(0, -1));
            methodAC = methodAC.replaceAll("#NOTYPEPARAMS#", parametersWithoutType.slice(0, -1));
            methodText += methodAC;
          }else if(/^C.*/.test(methodSemicolonSplitted[1])){
            let methodC = dynamicMethodC.replaceAll("#TYPE#", methodSemicolonSplitted[2]);
            methodC = methodC.replaceAll("#NAME#", methodHashSplitted[1]);
            methodC = methodC.replaceAll("#PARAMS#", parameters.slice(0, -1));
            methodC = methodC.replaceAll("#NOTYPEPARAMS#", parametersWithoutType.slice(0, -1));
            methodText += methodC;
          }
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
