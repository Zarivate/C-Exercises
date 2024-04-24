import React, { useState, ChangeEvent } from "react";

type Props = {};

const Search: React.FC<Props> = (props: Props): JSX.Element => {
  const [search, setSearch] = useState<string>("");

  const onSearchType = (e: ChangeEvent<HTMLInputElement>) => {
    setSearch(e.target.value);
    console.log(e);
  };

  return (
    <div>
      <input value={search} onChange={(e) => onSearchType(e)}></input>
    </div>
  );
};

export default Search;
