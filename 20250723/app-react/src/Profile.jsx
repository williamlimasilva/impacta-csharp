function Profile(props) {
  return (
    <div className="profile-card">
      <h2>{props.nome}</h2>
      <img src={props.imagemURL} alt={props.nome} width={200} height={300} />
    </div>
  );
}

export default Profile;
