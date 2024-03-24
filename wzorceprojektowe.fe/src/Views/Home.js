import React, { useEffect, useState } from "react";
import Header from "../Components/Header";
import Footer from "../Components/Footer";
import { GetPatternsByType } from "../Controllers/PatternController";
import { HashLoader } from "react-spinners";

const override = {
  display: "block",
  margin: "0 auto",
};

export default function Home() {
  const [patternData, setPatternData] = useState(null);
  const [isLoading, setIsLoading] = useState(false);

  useEffect(() => {
    FetchData();
  }, []);

  const FetchData = async () => {
    setIsLoading(true);

    const data = await GetPatternsByType({ type: "Structural" });
    if (data !== null) {
      setPatternData(data);
      console.log(data);
    }
    setIsLoading(false);
  };

  return (
    <div className="App">
      <Header />
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
          <div className="loadingText">Ładowanie szczegółów meczu</div>
        </>
      ) : patternData === null ? null : (
        <div>{patternData.map((item) => <div><p>Pattern name: {item.name}</p><p>Description: {item.description}</p><p>Schema: {item.schema}</p></div>)}</div>
      )}
      <Footer />
    </div>
  );
}
