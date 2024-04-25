import React, { useState, ChangeEvent, MouseEvent } from "react";

type Props = {};

const Search: React.FC<Props> = (props: Props): JSX.Element => {
  const [search, setSearch] = useState<string>("");

  const onSearchType = (e: ChangeEvent<HTMLInputElement>) => {
    setSearch(e.target.value);
    console.log(e);
  };

  // "SyntheticEvent" is also a good substitute if can't find type. Provides type checking as well.
  const onSearchButtonClick = (
    e: MouseEvent<HTMLButtonElement, globalThis.MouseEvent>
  ) => {
    console.log(e);
  };

  return (
    <div>
      <input value={search} onChange={(e) => onSearchType(e)}></input>
      <button onClick={(e) => onSearchButtonClick(e)}></button>
    </div>
  );
};

export default Search;
