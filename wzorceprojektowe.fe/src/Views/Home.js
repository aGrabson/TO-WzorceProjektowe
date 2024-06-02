import React, { useState} from "react";
import Header from "../Components/Header";
import Footer from "../Components/Footer";
import PatternConfPanel from "../Components/PatternConfPanel";
import PatternCodePanel from "../Components/PatternCodePanel";
import FileListPanel from "../Components/FileListPanel";
import { GetPatternCodeByName } from "../Controllers/PatternController";
import { HashLoader } from "react-spinners";

const override = {
  display: "block",
  margin: "0 auto",
};

export default function Home() {
  const [fileSelected, setFileSelected] = useState(null);
  const [patternData, setPatternData] = useState(null);
  const [isLoading, setIsLoading] = useState(false);
  const [files, setFiles] = useState(null);
  const [toInterpret, setToInterpret] = useState(null);
  const [dynamicClass, setDynamicClass] = useState(null);
  const [dynamicMethodI, setDynamicMethodI] = useState(null);
  const [dynamicMethodC, setDynamicMethodC] = useState(null);
  const [dynamicMethodAC, setDynamicMethodAC] = useState(null);

  const FetchCode = async (selectedItem) => {
    setIsLoading(true);
    const data = await GetPatternCodeByName({ patternName: selectedItem });
    if (data !== null) {
      console.log(data)
      setToInterpret(data.toInterpret);
      setFiles(data.listCodes);
      setFileSelected(data.listCodes[0]);
      setPatternData(data.listCodes[0].content);
      setDynamicClass(data.dynamicClass);
      setDynamicMethodI(data.dynamicMethodI);
      setDynamicMethodC(data.dynamicMethodC);
      setDynamicMethodAC(data.dynamicMethodAC);
    }
    setIsLoading(false);
  };

  const handleFileSelect = (fileIndex) => {
    const selectedFile = files[fileIndex];
    setFileSelected(selectedFile);
    setPatternData(selectedFile.content);
  };

  return (
    <div className="App">
      <>
        <Header FetchCode={FetchCode} toInterpret={toInterpret}/>
        <div style={{ display: "flex", flexDirection: "row", flex: 1, paddingBottom:40 }}>
          {isLoading ? (
            <>
              <HashLoader
                loading={isLoading}
                cssOverride={override}
                aria-label="Loading Spinner"
                data-testid="loader"
                color="#ffffff"
                size={50}
              />
              <div className="loadingText">Ładowanie</div>
            </>
          ) : (
            <>
              <PatternConfPanel fileSelected={fileSelected} files={files} setFiles={setFiles} toInterpret={toInterpret} setToInterpret={setToInterpret} dynamicClass={dynamicClass} />
              <div
                style={{ display: "flex", flexDirection: "column", flex: 1 }}
              >
                <FileListPanel files={files} onFileSelect={handleFileSelect} toInterpret={toInterpret}/>
                <PatternCodePanel patternData={patternData} toInterpret={toInterpret} dynamicMethodI={dynamicMethodI} dynamicMethodC={dynamicMethodC} dynamicMethodAC={dynamicMethodAC}/>
              </div>
            </>
          )}
        </div>
        <Footer />
      </>
    </div>
  );
}
