// selected Options Context

import React, { createContext, useState, useContext, ReactNode } from 'react';

interface SelectedOptionsContextType {
  state: SelectedOptions; // Define your state type
  // Add more properties and methods as needed
}

interface SelectedOptions {
  bible: String,
  book: number,
  chapter: number,
  version: String,
  books: bookOption[],
}

interface bookOption {
  id: number,
  name: String,
  chapterCount: number,
}


var defaultBookList: bookOption[];

defaultBookList = [
  {
    id: 1,
    name: "Genesis",
    chapterCount: 50,
  },
  {
    id: 2,
    name: "Exodus",
    chapterCount: 40,
  },
  {
    id: 3,
    name: "Leviticus",
    chapterCount: 27,
  },
  {
    id: 4,
    name: "Numbers",
    chapterCount: 36,
  },
  {
    id: 5,
    name: "Deuteronomy",
    chapterCount: 34,
  },
  {
    id: 6,
    name: "Joshua",
    chapterCount: 24,
  },
  {
    id: 7,
    name: "Judges",
    chapterCount: 21,
  },
  {
    id: 8,
    name: "Ruth",
    chapterCount: 4,
  },
  {
    id: 9,
    name: "1 Samuel",
    chapterCount: 31,
  },
  {
    id: 10,
    name: "2 Samuel",
    chapterCount: 24,
  },
  {
    id: 11,
    name: "1 Kings",
    chapterCount: 22,
  },
  {
    id: 12,
    name: "2 Kings",
    chapterCount: 25,
  },
  {
    id: 13,
    name: "1 Chronicles",
    chapterCount: 29,
  },
  {
    id: 14,
    name: "2 Chronicles",
    chapterCount: 36,
  },
  {
    id: 15,
    name: "Ezra",
    chapterCount: 10,
  },
  {
    id: 16,
    name: "Nehemiah",
    chapterCount: 13,
  },
  {
    id: 17,
    name: "Esther",
    chapterCount: 10,
  },
  {
    id: 18,
    name: "Job",
    chapterCount: 42,
  },
  {
    id: 19,
    name: "Psalms",
    chapterCount: 150,
  },
  {
    id: 20,
    name: "Proverbs",
    chapterCount: 31,
  },
  {
    id: 21,
    name: "Ecclesiastes",
    chapterCount: 12,
  },
  {
    id: 22,
    name: "Song of Solomon",
    chapterCount: 8,
  },
  {
    id: 23,
    name: "Isaiah",
    chapterCount: 66,
  },
  {
    id: 24,
    name: "Jeremiah",
    chapterCount: 52,
  },
  {
    id: 25,
    name: "Lamentations",
    chapterCount: 5,
  },
  {
    id: 26,
    name: "Ezekiel",
    chapterCount: 48,
  },
  {
    id: 27,
    name: "Daniel",
    chapterCount: 12,
  },
  {
    id: 28,
    name: "Hosea",
    chapterCount: 14,
  },
  {
    id: 29,
    name: "Joel",
    chapterCount: 3,
  },
  {
    id: 30,
    name: "Amos",
    chapterCount: 9,
  },
  {
    id: 31,
    name: "Obadiah",
    chapterCount: 1,
  },
  {
    id: 32,
    name: "Jonah",
    chapterCount: 4,
  },
  {
    id: 33,
    name: "Micah",
    chapterCount: 7,
  },
  {
    id: 34,
    name: "Nahum",
    chapterCount: 3,
  },
  {
    id: 35,
    name: "Habakkuk",
    chapterCount: 3,
  },
  {
    id: 36,
    name: "Zephaniah",
    chapterCount: 3,
  },
  {
    id: 37,
    name: "Haggai",
    chapterCount: 2,
  },
  {
    id: 38,
    name: "Zechariah",
    chapterCount: 14,
  },
  {
    id: 39,
    name: "Malachi",
    chapterCount: 4,
  },
  {
    id: 40,
    name: "Matthew",
    chapterCount: 28,
  },
  {
    id: 41,
    name: "Mark",
    chapterCount: 16,
  },
  {
    id: 42,
    name: "Luke",
    chapterCount: 24,
  },
  {
    id: 43,
    name: "John",
    chapterCount: 21,
  },
  {
    id: 44,
    name: "Acts",
    chapterCount: 28,
  },
  {
    id: 45,
    name: "Romans",
    chapterCount: 16,
  },
  {
    id: 46,
    name: "1 Corinthians",
    chapterCount: 16,
  },
  {
    id: 47,
    name: "2 Corinthians",
    chapterCount: 13,
  },
  {
    id: 48,
    name: "Galatians",
    chapterCount: 6,
  },
  {
    id: 49,
    name: "Ephesians",
    chapterCount: 6,
  },
  {
    id: 50,
    name: "Philippians",
    chapterCount: 4,
  },
  {
    id: 51,
    name: "Colossians",
    chapterCount: 4,
  },
  {
    id: 52,
    name: "1 Thessalonians",
    chapterCount: 5,
  },
  {
    id: 53,
    name: "2 Thessalonians",
    chapterCount: 3,
  },
  {
    id: 54,
    name: "1 Timothy",
    chapterCount: 6,
  },
  {
    id: 55,
    name: "2 Timothy",
    chapterCount: 4,
  },
  {
    id: 56,
    name: "Titus",
    chapterCount: 3,
  },
  {
    id: 57,
    name: "Philemon",
    chapterCount: 1,
  },
  {
    id: 58,
    name: "Hebrews",
    chapterCount: 13,
  },
  {
    id: 59,
    name: "James",
    chapterCount: 5,
  },
  {
    id: 60,
    name: "1 Peter",
    chapterCount: 5,
  },
  {
    id: 61,
    name: "2 Peter",
    chapterCount: 3,
  },
  {
    id: 62,
    name: "1 John",
    chapterCount: 5,
  },
  {
    id: 63,
    name: "2 John",
    chapterCount: 1,
  },
  {
    id: 64,
    name: "3 John",
    chapterCount: 1,
  },
  {
    id: 65,
    name: "Jude",
    chapterCount: 1,
  },
  {
    id: 66,
    name: "Revelation",
    chapterCount: 22,
  },
];


interface MyContextProviderProps {
  children: ReactNode;
}

const SelectedOptionsContext = createContext<SelectedOptionsContextType | undefined>(undefined);

const SelectedOptionsContextProvider: React.FC<MyContextProviderProps> = ({ children }) => {
  const [state, setState] = useState<SelectedOptions>({
    bible: "t_kjv",
    book: 1,
    chapter: 1,
    version: "King James Version",
    books : defaultBookList,
  });

  // Your context provider logic here

  return <SelectedOptionsContext.Provider value={{ state }}>{children}</SelectedOptionsContext.Provider>;
};

const useSelectedOptionsContext = () => {
  const context = useContext(SelectedOptionsContext);
  if (!context) {
    throw new Error('useSelectedOptionsContext must be used within a SelectedOptionsContextProvider');
  }
  return context;
};

export { SelectedOptionsContextProvider, useSelectedOptionsContext };
