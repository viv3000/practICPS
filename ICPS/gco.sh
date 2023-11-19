files=$(find . -name "*" -type f -exec ls  {} \; | grep ".cs" | grep -v ".csp" | grep -v "./bin" | grep -v "./obj")

echo "  <ItemGroup>";
for file in $files;
do
	echo '    <Compile Include="'$1''$file'" />'  | sed -e "s/\.[/]//";
done;
echo "  </ItemGroup>";


dirs=$(find . -type d | sed -e "s/\.[/]//" | grep -v "\." | grep -v "bin" | grep -v "obj"); 

echo "  <ItemGroup>";
for dir in $dirs; 
do
	echo '    <Folder Include="'$1''$dir'" />' ;
done;
echo "  </ItemGroup>";

